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
    public partial class FormMenu : Form
    {
        
        public FormMenu()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormConsulta fmConsultas = new FormConsulta();
            fmConsultas.ShowDialog();
        }

        // Bruno Brunelli
        
        // Cadastro de Ocorrencia
        private void registroOcorrênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOcr fmOcr = new FormOcr();
            fmOcr.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            FormOcr fmOcr = new FormOcr();
            fmOcr.ShowDialog();
        }

        // Cadastro
        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadUsuarios fmCadUs = new FormCadUsuarios();
            fmCadUs.ShowDialog();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            FormCadUsuarios fmCadUs = new FormCadUsuarios();
            fmCadUs.ShowDialog();
        }
        
        // Consultas



        // Manutenção        
        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManuCategoria fmManuCat = new FormManuCategoria();
            fmManuCat.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            FormManuCategoria fmManuCat = new FormManuCategoria();
            fmManuCat.ShowDialog();
        }

        private void locaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManuLocais fmManuLoc = new FormManuLocais();
            fmManuLoc.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            FormManuLocais fmManuLoc = new FormManuLocais();
            fmManuLoc.ShowDialog();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManuStatus fmManuStat = new FormManuStatus();
            fmManuStat.ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            FormManuStatus fmManuStat = new FormManuStatus();
            fmManuStat.ShowDialog();
        }


        // Ferramentas
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }


        


        



        
    }
}
