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
                tbl_Ocorrencia objOcr = new tbl_Ocorrencia();

                objOcr.Tec_Ocr = txtbxTec.Text;
                objOcr.DataSolucao_Ocr = Convert.ToDateTime(dtetmepkrDataSoluc.Value);
                objOcr.Solucao_Ocr = txtbxObsTec.Text;
                objOcr.Status_Ocr = cmbxSituacao.Text;

                Ocr.tbl_Ocorrencias.InsertOnSubmit(objOcr);
                Ocr.SubmitChanges();

                MessageBox.Show("O Estado da ocorrência foi alterado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Conectar();

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

            /*using (HelpDesk.DataClassCategoriasDataContext Categorias = new DataClassCategoriasDataContext())
            {
                cmbxCat.ValueMember = "Id_Cat";
                cmbxCat.DisplayMember = "Descricao_Cat";
                cmbxCat.DataSource = Categorias.tbl_Categorias.ToList();
            }*/
        }

        private void Conectar()
        {
            string Conexao = HelpDesk.Properties.Settings.Default.DatabaseHelpDeskConnectionString;

            ObjConectar = new SqlConnection(Conexao);
            ObjConectar.Open();
        }
    }
}
