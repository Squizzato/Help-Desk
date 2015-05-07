using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk
{
    public partial class FormConsulta : Form
    {
        public static int ID;

        public FormConsulta()
        {
            InitializeComponent();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                DataClassOcorrenciaDataContext objOcr = new DataClassOcorrenciaDataContext();

                var pesquisaOcr = from ocr in objOcr.tbl_Ocorrencias
                                  orderby ocr.Data_Ocr descending
                                  select ocr;
                dataGridViewOcr.DataSource = pesquisaOcr;

                dataGridViewOcr.Columns[0].HeaderCell.Value = "ID_Ocorrência";
                dataGridViewOcr.Columns[1].HeaderCell.Value = "Solicitante";
                dataGridViewOcr.Columns[2].HeaderCell.Value = "Data_Requisição";
                dataGridViewOcr.Columns[3].HeaderCell.Value = "Categoria";
                dataGridViewOcr.Columns[4].HeaderCell.Value = "Local";
                dataGridViewOcr.Columns[5].HeaderCell.Value = "Equipamento";
                dataGridViewOcr.Columns[6].HeaderCell.Value = "Descrição";
                dataGridViewOcr.Columns[7].HeaderCell.Value = "Observação";
                dataGridViewOcr.Columns[8].HeaderCell.Value = "Técnico";
                dataGridViewOcr.Columns[9].HeaderCell.Value = "Data_Solução";
                dataGridViewOcr.Columns[10].HeaderCell.Value = "Solução";
                dataGridViewOcr.Columns[11].HeaderCell.Value = "Status";

                int i = 0;
                int rowindex = dataGridViewOcr.CurrentRow.Index;

                i = Convert.ToInt32(dataGridViewOcr.Rows[rowindex].Cells[0].Value);
                ID = i;
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

        private void tabControlCons_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                DataClassUsuariosDataContext objUsuarios = new DataClassUsuariosDataContext();

                var pesquisaUs = from solicitantes in objUsuarios.tbl_Usuarios
                                 where solicitantes.NvAcesso_Us.Equals("Solicitante")
                                 select solicitantes;
                dataGridViewSol.DataSource = pesquisaUs;

                dataGridViewSol.Columns[0].HeaderCell.Value = "ID_Solicitante";
                dataGridViewSol.Columns[1].HeaderCell.Value = "Nome";
                dataGridViewSol.Columns[2].HeaderCell.Value = "Status";
                dataGridViewSol.Columns[3].HeaderCell.Value = "Email";
                dataGridViewSol.Columns[4].HeaderCell.Value = "Login";
                dataGridViewSol.Columns[5].HeaderCell.Value = "Senha";
            }
            catch (Exception erroSolic)
            {
                MessageBox.Show(erroSolic.Message);
            }
        }

        private void tabControlCons_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataClassUsuariosDataContext objUsuarios = new DataClassUsuariosDataContext();

                var pesquisaTec = from tecnicos in objUsuarios.tbl_Usuarios
                                 where tecnicos.NvAcesso_Us.Equals("Técnico")
                                 select tecnicos;
                dataGridViewTec.DataSource = pesquisaTec;

                dataGridViewSol.Columns[0].HeaderCell.Value = "ID_Técnico";
                dataGridViewSol.Columns[1].HeaderCell.Value = "Nome";
                dataGridViewSol.Columns[2].HeaderCell.Value = "Status";
                dataGridViewSol.Columns[3].HeaderCell.Value = "Email";
                dataGridViewSol.Columns[4].HeaderCell.Value = "Login";
                dataGridViewSol.Columns[5].HeaderCell.Value = "Senha";
            }
            catch (Exception erroTec)
            {
                MessageBox.Show(erroTec.Message);
            }
        }

        private void dataGridViewOcr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow rw in this.dataGridViewOcr.Rows)
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[8].Value == null || rw.Cells[8].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[8].Value.ToString()))
                    {
                        rw.Cells[8].Value = "Técnico responsável";
                    }

                    if (rw.Cells[9].Value == null || rw.Cells[9].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[9].Value.ToString()))
                    {
                        rw.Cells[9].Value = DateTime.Now;
                    }

                    if (rw.Cells[10].Value == null || rw.Cells[10].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[10].Value.ToString()))
                    {
                        rw.Cells[10].Value = "Solução";
                    }

                    if (rw.Cells[11].Value == null || rw.Cells[11].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[11].Value.ToString()))
                    {
                        rw.Cells[11].Value = "Em espera";
                    }
                }
            }

            FormOcr.solOco = dataGridViewOcr.CurrentRow.Cells[1].Value.ToString();
            FormOcr.dataOco = dataGridViewOcr.CurrentRow.Cells[2].Value.ToString();
            FormOcr.catOco = dataGridViewOcr.CurrentRow.Cells[3].Value.ToString();
            FormOcr.localOco = dataGridViewOcr.CurrentRow.Cells[4].Value.ToString();
            FormOcr.equipOco = dataGridViewOcr.CurrentRow.Cells[5].Value.ToString();
            FormOcr.descOco = dataGridViewOcr.CurrentRow.Cells[6].Value.ToString();
            FormOcr.obserOco = dataGridViewOcr.CurrentRow.Cells[7].Value.ToString();
            FormOcr.tecOco = dataGridViewOcr.CurrentRow.Cells[8].Value.ToString();
            FormOcr.dataSolOco = dataGridViewOcr.CurrentRow.Cells[9].Value.ToString();
            FormOcr.soluOco = dataGridViewOcr.CurrentRow.Cells[10].Value.ToString();
            FormOcr.statusOco = dataGridViewOcr.CurrentRow.Cells[11].Value.ToString();

            FormOcr objFormOcr = new FormOcr();
            objFormOcr.ShowDialog();
        }
    }
}
