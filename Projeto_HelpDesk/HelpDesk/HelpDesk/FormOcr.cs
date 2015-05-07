using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk
{
    public partial class FormOcr : Form
    {
        public static string solOco, dataOco, catOco, localOco, equipOco, descOco, obserOco, tecOco, dataSolOco, soluOco, statusOco;

        SqlConnection ObjConectar;

        public FormOcr()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                DataClassOcorrenciaDataContext Ocr = new DataClassOcorrenciaDataContext(HelpDesk.Properties.Settings.Default.DatabaseHelpDeskConnectionString);
                tbl_Ocorrencia objOcr = new tbl_Ocorrencia();

                objOcr.Sol_Ocr = txtbxSol.Text;
                objOcr.Data_Ocr = Convert.ToDateTime(dtetmepkrDataSolic.Value);
                objOcr.Cat_Ocr = cmbxCat.Text;
                objOcr.Equipamento_Ocr = txtbxEquip.Text;
                objOcr.Local_Ocr = cmbxLocal.Text;
                objOcr.Descricao_Ocr = txtbxDescProb.Text;
                objOcr.Observacao_Ocr = txtbxObsSol.Text;

                Ocr.tbl_Ocorrencias.InsertOnSubmit(objOcr);
                Ocr.SubmitChanges();

                MessageBox.Show("Ocorrência cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
           
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            try
            {
                DataClassOcorrenciaDataContext Ocr = new DataClassOcorrenciaDataContext(HelpDesk.Properties.Settings.Default.DatabaseHelpDeskConnectionString);

                var Atualizar = from ocorrencias in Ocr.tbl_Ocorrencias
                                where ocorrencias.Id_Ocr == FormConsulta.ID
                                select ocorrencias;

                foreach (var Ocorrencia in Atualizar)
                {
                    Ocorrencia.Sol_Ocr = txtbxSol.Text;
                    Ocorrencia.Data_Ocr = Convert.ToDateTime(dtetmepkrDataSolic.Value);
                    Ocorrencia.Cat_Ocr = cmbxCat.Text;
                    Ocorrencia.Equipamento_Ocr = txtbxEquip.Text;
                    Ocorrencia.Local_Ocr = cmbxLocal.Text;
                    Ocorrencia.Descricao_Ocr = txtbxDescProb.Text;
                    Ocorrencia.Observacao_Ocr = txtbxObsSol.Text;
                    Ocorrencia.Tec_Ocr = txtbxTec.Text;
                    Ocorrencia.DataSolucao_Ocr = Convert.ToDateTime(dtetmepkrDataSoluc.Value);
                    Ocorrencia.Solucao_Ocr = txtbxObsTec.Text;
                    Ocorrencia.Status_Ocr = cmbxSituacao.Text;

                    Ocr.SubmitChanges();
                }

                MessageBox.Show("A ocorrência foi atualizada com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbxSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxSituacao.Text.Equals("Em espera"))
            {
                pictureBoxConcluido.Visible = false;
                pictureBoxEspera.Visible = true;
            }
            else if (cmbxSituacao.Text.Equals("Resolvida"))
            {
                pictureBoxEspera.Visible = false;
                pictureBoxConcluido.Visible = true;
            }
        }

        private void FormOcr_Load(object sender, EventArgs e)
        {
            txtbxSol.Text = solOco;
            dtetmepkrDataSolic.Text = dataOco;
            cmbxCat.Text = catOco;
            cmbxLocal.Text = localOco;
            txtbxEquip.Text = equipOco;
            txtbxDescProb.Text = descOco;
            txtbxObsSol.Text = obserOco;
            txtbxTec.Text = tecOco;
            dtetmepkrDataSoluc.Text = dataSolOco;
            txtbxObsTec.Text = soluOco;
            cmbxSituacao.Text = statusOco;

            Conectar();
            
            // Combo Categoria
            try
            {
                string pesquisa = "SELECT * FROM tbl_Categoria";
                SqlCommand pesquisar = new SqlCommand(pesquisa, ObjConectar);
                SqlDataReader registros = pesquisar.ExecuteReader();

                cmbxCat.Items.Clear();

                while (registros.Read())
                {
                    cmbxCat.Items.Add(registros[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ObjConectar.Close();
            ObjConectar.Open();

            // Combo Local
            try
            {
                string pesquisaLocal = "SELECT * FROM tbl_Local";
                SqlCommand objPesquisaLocal = new SqlCommand(pesquisaLocal, ObjConectar);
                SqlDataReader registrosLocal = objPesquisaLocal.ExecuteReader();

                cmbxLocal.Items.Clear();

                while(registrosLocal.Read())
                {
                    cmbxLocal.Items.Add(registrosLocal[1]);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + erro.Message);
            }

            ObjConectar.Close();
            ObjConectar.Open();

            // Combo Status
            try
            {
                string pesquisaStatus = "SELECT * FROM tbl_Status";
                SqlCommand objPesquisasStatus = new SqlCommand(pesquisaStatus, ObjConectar);
                SqlDataReader registrosStatus = objPesquisasStatus.ExecuteReader();

                cmbxSituacao.Items.Clear();

                while (registrosStatus.Read())
                {
                    cmbxSituacao.Items.Add(registrosStatus[1]);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + erro.Message);
            }

            // Fechando a Conexão
            ObjConectar.Close();

            if (cmbxSituacao.Text.Equals("Em espera"))
            {
                pictureBoxConcluido.Visible = false;
                pictureBoxEspera.Visible = true;
            }
            else if (cmbxSituacao.Text.Equals("Resolvida"))
            {
                pictureBoxEspera.Visible = false;
                pictureBoxConcluido.Visible = true;
            }
        }

        private void Conectar()
        {
            string Conexao = HelpDesk.Properties.Settings.Default.DatabaseHelpDeskConnectionString;

            ObjConectar = new SqlConnection(Conexao);
            ObjConectar.Open();
        }

        private void cmbxCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
