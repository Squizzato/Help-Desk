namespace HelpDesk
{
    partial class FormOcr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOcr));
            this.tabControlOcr = new System.Windows.Forms.TabControl();
            this.tabPageSol = new System.Windows.Forms.TabPage();
            this.txtbxObsSol = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxDescProb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxEquip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxLocal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxCat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxSol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageTec = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbxObsTec = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbxSituacao = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbxTec = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.pictureBoxEspera = new System.Windows.Forms.PictureBox();
            this.pictureBoxConcluido = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtetmepkrDataSolic = new System.Windows.Forms.DateTimePicker();
            this.dtetmepkrDataSoluc = new System.Windows.Forms.DateTimePicker();
            this.tabControlOcr.SuspendLayout();
            this.tabPageSol.SuspendLayout();
            this.tabPageTec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEspera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConcluido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlOcr
            // 
            this.tabControlOcr.Controls.Add(this.tabPageSol);
            this.tabControlOcr.Controls.Add(this.tabPageTec);
            this.tabControlOcr.Location = new System.Drawing.Point(12, 97);
            this.tabControlOcr.Name = "tabControlOcr";
            this.tabControlOcr.SelectedIndex = 0;
            this.tabControlOcr.Size = new System.Drawing.Size(576, 437);
            this.tabControlOcr.TabIndex = 15;
            // 
            // tabPageSol
            // 
            this.tabPageSol.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSol.Controls.Add(this.dtetmepkrDataSolic);
            this.tabPageSol.Controls.Add(this.txtbxObsSol);
            this.tabPageSol.Controls.Add(this.label8);
            this.tabPageSol.Controls.Add(this.btnReg);
            this.tabPageSol.Controls.Add(this.txtbxDescProb);
            this.tabPageSol.Controls.Add(this.label7);
            this.tabPageSol.Controls.Add(this.txtbxEquip);
            this.tabPageSol.Controls.Add(this.label6);
            this.tabPageSol.Controls.Add(this.cmbxLocal);
            this.tabPageSol.Controls.Add(this.label5);
            this.tabPageSol.Controls.Add(this.cmbxCat);
            this.tabPageSol.Controls.Add(this.label4);
            this.tabPageSol.Controls.Add(this.label3);
            this.tabPageSol.Controls.Add(this.txtbxSol);
            this.tabPageSol.Controls.Add(this.label2);
            this.tabPageSol.Location = new System.Drawing.Point(4, 22);
            this.tabPageSol.Name = "tabPageSol";
            this.tabPageSol.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSol.Size = new System.Drawing.Size(568, 411);
            this.tabPageSol.TabIndex = 0;
            this.tabPageSol.Text = "Solicitação";
            // 
            // txtbxObsSol
            // 
            this.txtbxObsSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxObsSol.Location = new System.Drawing.Point(16, 309);
            this.txtbxObsSol.Multiline = true;
            this.txtbxObsSol.Name = "txtbxObsSol";
            this.txtbxObsSol.Size = new System.Drawing.Size(539, 42);
            this.txtbxObsSol.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Observação:";
            // 
            // txtbxDescProb
            // 
            this.txtbxDescProb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDescProb.Location = new System.Drawing.Point(16, 189);
            this.txtbxDescProb.Multiline = true;
            this.txtbxDescProb.Name = "txtbxDescProb";
            this.txtbxDescProb.Size = new System.Drawing.Size(539, 87);
            this.txtbxDescProb.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Descrição do problema:";
            // 
            // txtbxEquip
            // 
            this.txtbxEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEquip.Location = new System.Drawing.Point(142, 104);
            this.txtbxEquip.Name = "txtbxEquip";
            this.txtbxEquip.Size = new System.Drawing.Size(169, 22);
            this.txtbxEquip.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Equipamento:";
            // 
            // cmbxLocal
            // 
            this.cmbxLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxLocal.FormattingEnabled = true;
            this.cmbxLocal.Items.AddRange(new object[] {
            "Lab03",
            "Lab04",
            "Lab05",
            "Lab06"});
            this.cmbxLocal.Location = new System.Drawing.Point(418, 57);
            this.cmbxLocal.Name = "cmbxLocal";
            this.cmbxLocal.Size = new System.Drawing.Size(101, 24);
            this.cmbxLocal.TabIndex = 21;
            this.cmbxLocal.Text = "Selecione";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Local:";
            // 
            // cmbxCat
            // 
            this.cmbxCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxCat.FormattingEnabled = true;
            this.cmbxCat.Location = new System.Drawing.Point(142, 57);
            this.cmbxCat.Name = "cmbxCat";
            this.cmbxCat.Size = new System.Drawing.Size(169, 24);
            this.cmbxCat.TabIndex = 19;
            this.cmbxCat.Text = "Selecione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data:";
            // 
            // txtbxSol
            // 
            this.txtbxSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSol.Location = new System.Drawing.Point(142, 12);
            this.txtbxSol.Name = "txtbxSol";
            this.txtbxSol.Size = new System.Drawing.Size(169, 22);
            this.txtbxSol.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Solicitante:";
            // 
            // tabPageTec
            // 
            this.tabPageTec.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTec.Controls.Add(this.dtetmepkrDataSoluc);
            this.tabPageTec.Controls.Add(this.btnAtualizar);
            this.tabPageTec.Controls.Add(this.pictureBoxEspera);
            this.tabPageTec.Controls.Add(this.label12);
            this.tabPageTec.Controls.Add(this.txtbxObsTec);
            this.tabPageTec.Controls.Add(this.label11);
            this.tabPageTec.Controls.Add(this.cmbxSituacao);
            this.tabPageTec.Controls.Add(this.label9);
            this.tabPageTec.Controls.Add(this.txtbxTec);
            this.tabPageTec.Controls.Add(this.label10);
            this.tabPageTec.Controls.Add(this.pictureBoxConcluido);
            this.tabPageTec.Location = new System.Drawing.Point(4, 22);
            this.tabPageTec.Name = "tabPageTec";
            this.tabPageTec.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTec.Size = new System.Drawing.Size(568, 411);
            this.tabPageTec.TabIndex = 1;
            this.tabPageTec.Text = "Estado da solicitação";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(412, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Data:";
            // 
            // txtbxObsTec
            // 
            this.txtbxObsTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxObsTec.Location = new System.Drawing.Point(20, 81);
            this.txtbxObsTec.Multiline = true;
            this.txtbxObsTec.Name = "txtbxObsTec";
            this.txtbxObsTec.Size = new System.Drawing.Size(539, 42);
            this.txtbxObsTec.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Observação:";
            // 
            // cmbxSituacao
            // 
            this.cmbxSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxSituacao.FormattingEnabled = true;
            this.cmbxSituacao.Items.AddRange(new object[] {
            "Em espera",
            "Resolvida"});
            this.cmbxSituacao.Location = new System.Drawing.Point(87, 151);
            this.cmbxSituacao.Name = "cmbxSituacao";
            this.cmbxSituacao.Size = new System.Drawing.Size(110, 24);
            this.cmbxSituacao.TabIndex = 23;
            this.cmbxSituacao.Text = "Em espera";
            this.cmbxSituacao.SelectedIndexChanged += new System.EventHandler(this.cmbxSituacao_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Situação:";
            // 
            // txtbxTec
            // 
            this.txtbxTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTec.Location = new System.Drawing.Point(161, 19);
            this.txtbxTec.Name = "txtbxTec";
            this.txtbxTec.Size = new System.Drawing.Size(226, 22);
            this.txtbxTec.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Técnico responsável:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(104, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registro de ocorrências";
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
            this.btnVoltar.Location = new System.Drawing.Point(12, 540);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(108, 36);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnReg
            // 
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReg.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReg.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReg.Image = ((System.Drawing.Image)(resources.GetObject("btnReg.Image")));
            this.btnReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReg.Location = new System.Drawing.Point(430, 369);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(125, 36);
            this.btnReg.TabIndex = 14;
            this.btnReg.Text = "     Registrar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(383, 374);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(176, 31);
            this.btnAtualizar.TabIndex = 226;
            this.btnAtualizar.Text = "      Atualizar Situação";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // pictureBoxEspera
            // 
            this.pictureBoxEspera.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEspera.Image")));
            this.pictureBoxEspera.Location = new System.Drawing.Point(220, 151);
            this.pictureBoxEspera.Name = "pictureBoxEspera";
            this.pictureBoxEspera.Size = new System.Drawing.Size(88, 91);
            this.pictureBoxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEspera.TabIndex = 32;
            this.pictureBoxEspera.TabStop = false;
            // 
            // pictureBoxConcluido
            // 
            this.pictureBoxConcluido.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxConcluido.Image")));
            this.pictureBoxConcluido.Location = new System.Drawing.Point(220, 154);
            this.pictureBoxConcluido.Name = "pictureBoxConcluido";
            this.pictureBoxConcluido.Size = new System.Drawing.Size(68, 82);
            this.pictureBoxConcluido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConcluido.TabIndex = 16;
            this.pictureBoxConcluido.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dtetmepkrDataSolic
            // 
            this.dtetmepkrDataSolic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtetmepkrDataSolic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtetmepkrDataSolic.Location = new System.Drawing.Point(418, 12);
            this.dtetmepkrDataSolic.Name = "dtetmepkrDataSolic";
            this.dtetmepkrDataSolic.Size = new System.Drawing.Size(101, 22);
            this.dtetmepkrDataSolic.TabIndex = 28;
            // 
            // dtetmepkrDataSoluc
            // 
            this.dtetmepkrDataSoluc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtetmepkrDataSoluc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtetmepkrDataSoluc.Location = new System.Drawing.Point(458, 19);
            this.dtetmepkrDataSoluc.Name = "dtetmepkrDataSoluc";
            this.dtetmepkrDataSoluc.Size = new System.Drawing.Size(101, 22);
            this.dtetmepkrDataSoluc.TabIndex = 227;
            // 
            // FormOcr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tabControlOcr);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOcr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de ocorrências";
            this.Load += new System.EventHandler(this.FormOcr_Load);
            this.tabControlOcr.ResumeLayout(false);
            this.tabPageSol.ResumeLayout(false);
            this.tabPageSol.PerformLayout();
            this.tabPageTec.ResumeLayout(false);
            this.tabPageTec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEspera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConcluido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TabControl tabControlOcr;
        private System.Windows.Forms.TabPage tabPageSol;
        private System.Windows.Forms.TextBox txtbxObsSol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbxDescProb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbxEquip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxLocal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxSol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageTec;
        private System.Windows.Forms.ComboBox cmbxSituacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbxTec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBoxConcluido;
        private System.Windows.Forms.TextBox txtbxObsTec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBoxEspera;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtetmepkrDataSolic;
        private System.Windows.Forms.DateTimePicker dtetmepkrDataSoluc;
    }
}

