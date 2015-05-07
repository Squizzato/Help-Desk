namespace HelpDesk
{
    partial class FormManuLocais
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManuLocais));
            this.databaseHelpDeskDataSet = new HelpDesk.DatabaseHelpDeskDataSet();
            this.databaseHelpDeskDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridLocais = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocais = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.databaseHelpDeskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseHelpDeskDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseHelpDeskDataSet
            // 
            this.databaseHelpDeskDataSet.DataSetName = "DatabaseHelpDeskDataSet";
            this.databaseHelpDeskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseHelpDeskDataSetBindingSource
            // 
            this.databaseHelpDeskDataSetBindingSource.DataSource = this.databaseHelpDeskDataSet;
            this.databaseHelpDeskDataSetBindingSource.Position = 0;
            // 
            // dataGridLocais
            // 
            this.dataGridLocais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLocais.Location = new System.Drawing.Point(12, 156);
            this.dataGridLocais.Name = "dataGridLocais";
            this.dataGridLocais.Size = new System.Drawing.Size(660, 239);
            this.dataGridLocais.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Locais:";
            // 
            // txtLocais
            // 
            this.txtLocais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocais.Location = new System.Drawing.Point(109, 119);
            this.txtLocais.Name = "txtLocais";
            this.txtLocais.Size = new System.Drawing.Size(228, 22);
            this.txtLocais.TabIndex = 37;
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
            this.btnVoltar.Location = new System.Drawing.Point(285, 413);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(125, 36);
            this.btnVoltar.TabIndex = 40;
            this.btnVoltar.Text = "     Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(416, 413);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(125, 36);
            this.btnExcluir.TabIndex = 39;
            this.btnExcluir.Text = "     Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(547, 413);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(125, 36);
            this.btnRegistrar.TabIndex = 38;
            this.btnRegistrar.Text = "     Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(82, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Cadastro e Consulta de Locais";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(684, 461);
            this.shapeContainer1.TabIndex = 48;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 11;
            this.lineShape1.X2 = 671;
            this.lineShape1.Y1 = 104;
            this.lineShape1.Y2 = 104;
            // 
            // FormManuLocais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridLocais);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocais);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManuLocais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema HelpDesk 1.4 - Manutenção - Locais";
            this.Load += new System.EventHandler(this.FormManuLocais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseHelpDeskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseHelpDeskDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseHelpDeskDataSet databaseHelpDeskDataSet;
        private System.Windows.Forms.BindingSource databaseHelpDeskDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridLocais;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocais;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}