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
    public partial class FormCadUsuarios : Form
    {
        public FormCadUsuarios()
        {
            InitializeComponent();
        }

        private void btnReg_Us_Click(object sender, EventArgs e)
        {
            try
            {
                DataClassUsuariosDataContext Usuarios = new DataClassUsuariosDataContext();
                tbl_Usuario objUs = new tbl_Usuario();

                bool ativo = false;
                if (cmbxStatus.Text != "Ativo" && cmbxNvAcesso.Text != "Inativo")
                {
                    MessageBox.Show("Status Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (cmbxNvAcesso.Text.Equals("Ativo"))
                    {
                        ativo = true;
                    }
                    else
                    {
                        ativo = false;
                    }
                }

                objUs.Nome_Us = txtbxNome.Text;
                objUs.Ativo_Us = ativo;
                objUs.Email_Us = txtbxEmail.Text;
                objUs.NvAcesso_Us = cmbxNvAcesso.Text;
                objUs.Login_Us = txtbxLogin.Text;
                objUs.Senha_Us = txtbxSenha.Text;

                Usuarios.tbl_Usuarios.InsertOnSubmit(objUs);
                Usuarios.SubmitChanges();

                MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
           
        }

        private void Limpar()
        {
            txtbxNome.Clear();
            cmbxStatus.Text = "Selecione";
            txtbxEmail.Clear();
            cmbxNvAcesso.Text = "Selecione";
            txtbxLogin.Clear();
            txtbxSenha.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
