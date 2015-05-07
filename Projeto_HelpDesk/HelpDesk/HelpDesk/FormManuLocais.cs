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
    public partial class FormManuLocais : Form
    {
        public FormManuLocais()
        {
            InitializeComponent();
        }

        private void FormManuLocais_Load(object sender, EventArgs e)
        {
                DataClassesLocaisDataContext objLoc = new DataClassesLocaisDataContext();
                var pesquisaLoc = from loc in objLoc.tbl_Locals
                                  select loc;
                dataGridLocais.DataSource = pesquisaLoc;

                dataGridLocais.Columns[0].HeaderCell.Value = "ID Local";
                dataGridLocais.Columns[1].HeaderCell.Value = "Descrição Local";   
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                DataClassesLocaisDataContext Locais = new DataClassesLocaisDataContext();
                tbl_Local objTblLocal = new tbl_Local();

                objTblLocal.Desc_Loc = txtLocais.Text;

                Locais.tbl_Locals.InsertOnSubmit(objTblLocal);
                Locais.SubmitChanges();

                MessageBox.Show("Local cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLocais.Clear();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataClassesLocaisDataContext Locais = new DataClassesLocaisDataContext();
            try
            {
                foreach (DataGridViewRow item in this.dataGridLocais.SelectedRows)
                {
                    dataGridLocais.Rows.RemoveAt(item.Index);
                    Locais.SubmitChanges();
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
