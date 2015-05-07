namespace HelpDesk
{
    partial class FormCadUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadUsuarios));
            this.pictureBoxCadUs = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSolicitante = new System.Windows.Forms.TabPage();
            this.cmbxStatus = new System.Windows.Forms.ComboBox();
            this.btnReg_Us = new System.Windows.Forms.Button();
            this.cmbxNvAcesso = new System.Windows.Forms.ComboBox();
            this.txtbxSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadUs)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabSolicitante.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCadUs
            // 
            this.pictureBoxCadUs.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCadUs.Image")));
            this.pictureBoxCadUs.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCadUs.Name = "pictureBoxCadUs";
            this.pictureBoxCadUs.Size = new System.Drawing.Size(71, 70);
            this.pictureBoxCadUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCadUs.TabIndex = 2;
            this.pictureBoxCadUs.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(102, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cadastro de usuários";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSolicitante);
            this.tabControl1.Location = new System.Drawing.Point(12, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 385);
            this.tabControl1.TabIndex = 19;
            // 
            // tabSolicitante
            // 
            this.tabSolicitante.Controls.Add(this.cmbxStatus);
            this.tabSolicitante.Controls.Add(this.btnReg_Us);
            this.tabSolicitante.Controls.Add(this.cmbxNvAcesso);
            this.tabSolicitante.Controls.Add(this.txtbxSenha);
            this.tabSolicitante.Controls.Add(this.label8);
            this.tabSolicitante.Controls.Add(this.txtbxLogin);
            this.tabSolicitante.Controls.Add(this.label7);
            this.tabSolicitante.Controls.Add(this.label6);
            this.tabSolicitante.Controls.Add(this.txtbxEmail);
            this.tabSolicitante.Controls.Add(this.label5);
            this.tabSolicitante.Controls.Add(this.label4);
            this.tabSolicitante.Controls.Add(this.txtbxNome);
            this.tabSolicitante.Controls.Add(this.label2);
            this.tabSolicitante.Controls.Add(this.shapeContainer1);
            this.tabSolicitante.Location = new System.Drawing.Point(4, 22);
            this.tabSolicitante.Name = "tabSolicitante";
            this.tabSolicitante.Padding = new System.Windows.Forms.Padding(3);
            this.tabSolicitante.Size = new System.Drawing.Size(552, 359);
            this.tabSolicitante.TabIndex = 0;
            this.tabSolicitante.Text = "Novo Usuário";
            // 
            // cmbxStatus
            // 
            this.cmbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbxStatus.FormattingEnabled = true;
            this.cmbxStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmbxStatus.Location = new System.Drawing.Point(169, 77);
            this.cmbxStatus.Name = "cmbxStatus";
            this.cmbxStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbxStatus.TabIndex = 2;
            this.cmbxStatus.Text = "Selecione";
            // 
            // btnReg_Us
            // 
            this.btnReg_Us.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReg_Us.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReg_Us.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnReg_Us.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg_Us.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg_Us.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReg_Us.Image = ((System.Drawing.Image)(resources.GetObject("btnReg_Us.Image")));
            this.btnReg_Us.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReg_Us.Location = new System.Drawing.Point(421, 317);
            this.btnReg_Us.Name = "btnReg_Us";
            this.btnReg_Us.Size = new System.Drawing.Size(125, 36);
            this.btnReg_Us.TabIndex = 7;
            this.btnReg_Us.Text = "     Registrar";
            this.btnReg_Us.UseVisualStyleBackColor = true;
            this.btnReg_Us.Click += new System.EventHandler(this.btnReg_Us_Click);
            // 
            // cmbxNvAcesso
            // 
            this.cmbxNvAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbxNvAcesso.FormattingEnabled = true;
            this.cmbxNvAcesso.Items.AddRange(new object[] {
            "Administrador",
            "Técnico",
            "Solicitante"});
            this.cmbxNvAcesso.Location = new System.Drawing.Point(169, 153);
            this.cmbxNvAcesso.Name = "cmbxNvAcesso";
            this.cmbxNvAcesso.Size = new System.Drawing.Size(121, 24);
            this.cmbxNvAcesso.TabIndex = 4;
            this.cmbxNvAcesso.Text = " Selecione";
            // 
            // txtbxSenha
            // 
            this.txtbxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSenha.Location = new System.Drawing.Point(169, 257);
            this.txtbxSenha.Name = "txtbxSenha";
            this.txtbxSenha.Size = new System.Drawing.Size(169, 22);
            this.txtbxSenha.TabIndex = 6;
            this.txtbxSenha.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = " Senha:";
            // 
            // txtbxLogin
            // 
            this.txtbxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLogin.Location = new System.Drawing.Point(169, 220);
            this.txtbxLogin.Name = "txtbxLogin";
            this.txtbxLogin.Size = new System.Drawing.Size(169, 22);
            this.txtbxLogin.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = " Login:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = " Nível de acesso:";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEmail.Location = new System.Drawing.Point(169, 116);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(310, 22);
            this.txtbxEmail.TabIndex = 3;
            this.txtbxEmail.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = " E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Status:";
            // 
            // txtbxNome
            // 
            this.txtbxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNome.Location = new System.Drawing.Point(169, 41);
            this.txtbxNome.Name = "txtbxNome";
            this.txtbxNome.Size = new System.Drawing.Size(310, 22);
            this.txtbxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(546, 353);
            this.shapeContainer1.TabIndex = 27;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 29;
            this.lineShape1.X2 = 517;
            this.lineShape1.Y1 = 198;
            this.lineShape1.Y2 = 198;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(12, 495);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(108, 36);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormCadUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(584, 547);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxCadUs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadUs)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabSolicitante.ResumeLayout(false);
            this.tabSolicitante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCadUs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSolicitante;
        private System.Windows.Forms.ComboBox cmbxStatus;
        private System.Windows.Forms.Button btnReg_Us;
        private System.Windows.Forms.ComboBox cmbxNvAcesso;
        private System.Windows.Forms.TextBox txtbxSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbxLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxNome;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnVoltar;
    }
}