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
        int X = 0;
        int Y = 0;

        public FormMenu()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FormMenu_MouseDown);
            this.MouseMove += new MouseEventHandler(FormMenu_MouseMove);
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormOcr fmOcr = new FormOcr();
            fmOcr.ShowDialog();
        }

        private void FormMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;     
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FormMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;   
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormConsulta fmConsultas = new FormConsulta();
            fmConsultas.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FormCadUsuarios fmCadUs = new FormCadUsuarios();
            fmCadUs.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FormManutencao fmManutencao = new FormManutencao();
            fmManutencao.ShowDialog();
        }
    }
}
