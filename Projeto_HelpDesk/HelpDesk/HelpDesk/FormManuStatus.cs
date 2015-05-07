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
    public partial class FormManuStatus : Form
    {
        public FormManuStatus()
        {
            InitializeComponent();
        }

        private void FormManuStatus_Load(object sender, EventArgs e)
        {
            DataClassesStatusDataContext objStat = new DataClassesStatusDataContext();
            var pesquisaStat = from stat in objStat.tbl_Status
                               select stat;
            dataGridStatus.DataSource = pesquisaStat;

            dataGridStatus.Columns[0].HeaderCell.Value = "ID Status";
            dataGridStatus.Columns[1].HeaderCell.Value = "Descrição Status";

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                DataClassesStatusDataContext Status = new DataClassesStatusDataContext();
                tbl_Status objTblStat = new tbl_Status();

                objTblStat.Desc_Status = txtStatus.Text;

                Status.tbl_Status.InsertOnSubmit(objTblStat);
                Status.SubmitChanges();

                MessageBox.Show("Status cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStatus.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataClassesStatusDataContext Status = new DataClassesStatusDataContext();
            try
            {
                foreach (DataGridViewRow item in this.dataGridStatus.SelectedRows)
                {
                    dataGridStatus.Rows.RemoveAt(item.Index);
                    Status.SubmitChanges();
                }
                MessageBox.Show("Usuário excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
           
        }
    }
}
