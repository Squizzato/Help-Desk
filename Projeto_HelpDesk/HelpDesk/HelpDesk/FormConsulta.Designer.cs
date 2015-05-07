namespace HelpDesk
{
    partial class FormConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlCons = new System.Windows.Forms.TabControl();
            this.tabPageOcr = new System.Windows.Forms.TabPage();
            this.btnDelOcr = new System.Windows.Forms.Button();
            this.dataGridViewOcr = new System.Windows.Forms.DataGridView();
            this.tabPageSolicitante = new System.Windows.Forms.TabPage();
            this.btnUpdate_Sol = new System.Windows.Forms.Button();
            this.btnExcluir_Sol = new System.Windows.Forms.Button();
            this.dataGridViewSol = new System.Windows.Forms.DataGridView();
            this.tabPageTecnico = new System.Windows.Forms.TabPage();
            this.btnUpdate_Tec = new System.Windows.Forms.Button();
            this.btnExcluir_Tec = new System.Windows.Forms.Button();
            this.dataGridViewTec = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBoxCons = new System.Windows.Forms.PictureBox();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControlCons.SuspendLayout();
            this.tabPageOcr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOcr)).BeginInit();
            this.tabPageSolicitante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSol)).BeginInit();
            this.tabPageTecnico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCons)).BeginInit();
            this.tabPageAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(100, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Consultas";
            // 
            // tabControlCons
            // 
            this.tabControlCons.Controls.Add(this.tabPageOcr);
            this.tabControlCons.Controls.Add(this.tabPageSolicitante);
            this.tabControlCons.Controls.Add(this.tabPageTecnico);
            this.tabControlCons.Controls.Add(this.tabPageAdmin);
            this.tabControlCons.Location = new System.Drawing.Point(12, 104);
            this.tabControlCons.Name = "tabControlCons";
            this.tabControlCons.SelectedIndex = 0;
            this.tabControlCons.Size = new System.Drawing.Size(576, 358);
            this.tabControlCons.TabIndex = 19;
            this.tabControlCons.SelectedIndexChanged += new System.EventHandler(this.tabControlCons_SelectedIndexChanged);
            this.tabControlCons.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlCons_Selected);
            // 
            // tabPageOcr
            // 
            this.tabPageOcr.Controls.Add(this.btnDelOcr);
            this.tabPageOcr.Controls.Add(this.dataGridViewOcr);
            this.tabPageOcr.Location = new System.Drawing.Point(4, 22);
            this.tabPageOcr.Name = "tabPageOcr";
            this.tabPageOcr.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOcr.Size = new System.Drawing.Size(568, 332);
            this.tabPageOcr.TabIndex = 0;
            this.tabPageOcr.Text = "Ocorrências";
            this.tabPageOcr.UseVisualStyleBackColor = true;
            // 
            // btnDelOcr
            // 
            this.btnDelOcr.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelOcr.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelOcr.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelOcr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelOcr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelOcr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelOcr.Image = ((System.Drawing.Image)(resources.GetObject("btnDelOcr.Image")));
            this.btnDelOcr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelOcr.Location = new System.Drawing.Point(437, 290);
            this.btnDelOcr.Name = "btnDelOcr";
            this.btnDelOcr.Size = new System.Drawing.Size(125, 36);
            this.btnDelOcr.TabIndex = 15;
            this.btnDelOcr.Text = "     Excluir";
            this.btnDelOcr.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOcr
            // 
            this.dataGridViewOcr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOcr.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOcr.Name = "dataGridViewOcr";
            this.dataGridViewOcr.Size = new System.Drawing.Size(562, 281);
            this.dataGridViewOcr.TabIndex = 1;
            this.dataGridViewOcr.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOcr_CellDoubleClick);
            // 
            // tabPageSolicitante
            // 
            this.tabPageSolicitante.Controls.Add(this.btnUpdate_Sol);
            this.tabPageSolicitante.Controls.Add(this.btnExcluir_Sol);
            this.tabPageSolicitante.Controls.Add(this.dataGridViewSol);
            this.tabPageSolicitante.Location = new System.Drawing.Point(4, 22);
            this.tabPageSolicitante.Name = "tabPageSolicitante";
            this.tabPageSolicitante.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSolicitante.Size = new System.Drawing.Size(568, 332);
            this.tabPageSolicitante.TabIndex = 1;
            this.tabPageSolicitante.Text = "Solicitantes";
            this.tabPageSolicitante.UseVisualStyleBackColor = true;
            // 
            // btnUpdate_Sol
            // 
            this.btnUpdate_Sol.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate_Sol.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate_Sol.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate_Sol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_Sol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_Sol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate_Sol.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate_Sol.Image")));
            this.btnUpdate_Sol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate_Sol.Location = new System.Drawing.Point(437, 289);
            this.btnUpdate_Sol.Name = "btnUpdate_Sol";
            this.btnUpdate_Sol.Size = new System.Drawing.Size(125, 36);
            this.btnUpdate_Sol.TabIndex = 18;
            this.btnUpdate_Sol.Text = "     Atualizar";
            this.btnUpdate_Sol.UseVisualStyleBackColor = true;
            // 
            // btnExcluir_Sol
            // 
            this.btnExcluir_Sol.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExcluir_Sol.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExcluir_Sol.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnExcluir_Sol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir_Sol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir_Sol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir_Sol.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir_Sol.Image")));
            this.btnExcluir_Sol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir_Sol.Location = new System.Drawing.Point(306, 289);
            this.btnExcluir_Sol.Name = "btnExcluir_Sol";
            this.btnExcluir_Sol.Size = new System.Drawing.Size(125, 36);
            this.btnExcluir_Sol.TabIndex = 16;
            this.btnExcluir_Sol.Text = "     Excluir";
            this.btnExcluir_Sol.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSol
            // 
            this.dataGridViewSol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSol.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSol.Name = "dataGridViewSol";
            this.dataGridViewSol.Size = new System.Drawing.Size(562, 280);
            this.dataGridViewSol.TabIndex = 1;
            // 
            // tabPageTecnico
            // 
            this.tabPageTecnico.Controls.Add(this.btnUpdate_Tec);
            this.tabPageTecnico.Controls.Add(this.btnExcluir_Tec);
            this.tabPageTecnico.Controls.Add(this.dataGridViewTec);
            this.tabPageTecnico.Location = new System.Drawing.Point(4, 22);
            this.tabPageTecnico.Name = "tabPageTecnico";
            this.tabPageTecnico.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTecnico.Size = new System.Drawing.Size(568, 332);
            this.tabPageTecnico.TabIndex = 2;
            this.tabPageTecnico.Text = "Técnicos";
            this.tabPageTecnico.UseVisualStyleBackColor = true;
            // 
            // btnUpdate_Tec
            // 
            this.btnUpdate_Tec.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate_Tec.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate_Tec.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate_Tec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_Tec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_Tec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate_Tec.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate_Tec.Image")));
            this.btnUpdate_Tec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate_Tec.Location = new System.Drawing.Point(437, 289);
            this.btnUpdate_Tec.Name = "btnUpdate_Tec";
            this.btnUpdate_Tec.Size = new System.Drawing.Size(125, 36);
            this.btnUpdate_Tec.TabIndex = 17;
            this.btnUpdate_Tec.Text = "     Atualizar";
            this.btnUpdate_Tec.UseVisualStyleBackColor = true;
            // 
            // btnExcluir_Tec
            // 
            this.btnExcluir_Tec.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExcluir_Tec.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExcluir_Tec.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnExcluir_Tec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir_Tec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir_Tec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir_Tec.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir_Tec.Image")));
            this.btnExcluir_Tec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir_Tec.Location = new System.Drawing.Point(306, 289);
            this.btnExcluir_Tec.Name = "btnExcluir_Tec";
            this.btnExcluir_Tec.Size = new System.Drawing.Size(125, 36);
            this.btnExcluir_Tec.TabIndex = 16;
            this.btnExcluir_Tec.Text = "     Excluir";
            this.btnExcluir_Tec.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTec
            // 
            this.dataGridViewTec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTec.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTec.Name = "dataGridViewTec";
            this.dataGridViewTec.Size = new System.Drawing.Size(562, 280);
            this.dataGridViewTec.TabIndex = 0;
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
            this.btnVoltar.Location = new System.Drawing.Point(12, 468);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(108, 36);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBoxCons
            // 
            this.pictureBoxCons.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCons.Image")));
            this.pictureBoxCons.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCons.Name = "pictureBoxCons";
            this.pictureBoxCons.Size = new System.Drawing.Size(71, 70);
            this.pictureBoxCons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCons.TabIndex = 1;
            this.pictureBoxCons.TabStop = false;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.button1);
            this.tabPageAdmin.Controls.Add(this.button2);
            this.tabPageAdmin.Controls.Add(this.dataGridViewAdmin);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(568, 332);
            this.tabPageAdmin.TabIndex = 3;
            this.tabPageAdmin.Text = "Administradores";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(562, 280);
            this.dataGridViewAdmin.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(437, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "     Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(306, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "     Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 585);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tabControlCons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxCons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            this.tabControlCons.ResumeLayout(false);
            this.tabPageOcr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOcr)).EndInit();
            this.tabPageSolicitante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSol)).EndInit();
            this.tabPageTecnico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCons)).EndInit();
            this.tabPageAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlCons;
        private System.Windows.Forms.TabPage tabPageOcr;
        private System.Windows.Forms.TabPage tabPageSolicitante;
        private System.Windows.Forms.DataGridView dataGridViewOcr;
        private System.Windows.Forms.DataGridView dataGridViewSol;
        private System.Windows.Forms.TabPage tabPageTecnico;
        private System.Windows.Forms.DataGridView dataGridViewTec;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnDelOcr;
        private System.Windows.Forms.Button btnUpdate_Sol;
        private System.Windows.Forms.Button btnExcluir_Sol;
        private System.Windows.Forms.Button btnUpdate_Tec;
        private System.Windows.Forms.Button btnExcluir_Tec;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
    }
}