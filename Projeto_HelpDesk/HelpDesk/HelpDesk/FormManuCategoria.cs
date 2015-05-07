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
    public partial class FormManuCategoria : Form
    {
        public FormManuCategoria()
        {
            InitializeComponent();
        }

        private void FormManuCategoria_Load(object sender, EventArgs e)
        {
            
            DataClassCategoriasDataContext objCat = new DataClassCategoriasDataContext();
            var pesquisaCat = from cat in objCat.tbl_Categorias
                              select cat;
            dataGridCategoria.DataSource = pesquisaCat;

            dataGridCategoria.Columns[0].HeaderCell.Value = "ID Categoria";
            dataGridCategoria.Columns[1].HeaderCell.Value = "Descrição Categoria";

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
                DataClassCategoriasDataContext Categoria = new DataClassCategoriasDataContext();
                tbl_Categoria objTblCat = new tbl_Categoria();

                objTblCat.Descricao_Cat = txtCategoria.Text;

                Categoria.tbl_Categorias.InsertOnSubmit(objTblCat);
                Categoria.SubmitChanges();

                MessageBox.Show("Categoria cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategoria.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataClassCategoriasDataContext Categoria = new DataClassCategoriasDataContext();
            try
            {
                foreach (DataGridViewRow item in this.dataGridCategoria.SelectedRows)
                {
                    dataGridCategoria.Rows.RemoveAt(item.Index);
                    Categoria.SubmitChanges();
                }
                MessageBox.Show("Usuário excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
