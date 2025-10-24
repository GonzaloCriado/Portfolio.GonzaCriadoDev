namespace PlataformaMovieInsight
{
    partial class frmRegistrarVisualizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarVisualizaciones));
            this.grpRegistrar = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtCantidadVisualizaciones = new System.Windows.Forms.TextBox();
            this.lblTituloCantVisualizaciones = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbGeneros = new System.Windows.Forms.ComboBox();
            this.grpRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegistrar
            // 
            this.grpRegistrar.Controls.Add(this.btnCargar);
            this.grpRegistrar.Controls.Add(this.txtCantidadVisualizaciones);
            this.grpRegistrar.Controls.Add(this.lblTituloCantVisualizaciones);
            this.grpRegistrar.Controls.Add(this.cmbMes);
            this.grpRegistrar.Controls.Add(this.cmbGeneros);
            this.grpRegistrar.ForeColor = System.Drawing.Color.White;
            this.grpRegistrar.Location = new System.Drawing.Point(12, 11);
            this.grpRegistrar.Name = "grpRegistrar";
            this.grpRegistrar.Size = new System.Drawing.Size(364, 245);
            this.grpRegistrar.TabIndex = 0;
            this.grpRegistrar.TabStop = false;
            this.grpRegistrar.Text = "Complete los campos";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.Black;
            this.btnCargar.Location = new System.Drawing.Point(22, 187);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(321, 33);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar visualización";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtCantidadVisualizaciones
            // 
            this.txtCantidadVisualizaciones.Location = new System.Drawing.Point(219, 141);
            this.txtCantidadVisualizaciones.Name = "txtCantidadVisualizaciones";
            this.txtCantidadVisualizaciones.Size = new System.Drawing.Size(124, 20);
            this.txtCantidadVisualizaciones.TabIndex = 3;
            this.txtCantidadVisualizaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTituloCantVisualizaciones
            // 
            this.lblTituloCantVisualizaciones.AutoSize = true;
            this.lblTituloCantVisualizaciones.BackColor = System.Drawing.Color.White;
            this.lblTituloCantVisualizaciones.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCantVisualizaciones.ForeColor = System.Drawing.Color.Black;
            this.lblTituloCantVisualizaciones.Location = new System.Drawing.Point(19, 143);
            this.lblTituloCantVisualizaciones.Name = "lblTituloCantVisualizaciones";
            this.lblTituloCantVisualizaciones.Size = new System.Drawing.Size(146, 17);
            this.lblTituloCantVisualizaciones.TabIndex = 2;
            this.lblTituloCantVisualizaciones.Text = "Llenar visualizaciones:";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(20, 84);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(323, 21);
            this.cmbMes.TabIndex = 1;
            this.cmbMes.Text = "Seleccione un mes...";
            // 
            // cmbGeneros
            // 
            this.cmbGeneros.FormattingEnabled = true;
            this.cmbGeneros.Location = new System.Drawing.Point(20, 34);
            this.cmbGeneros.Name = "cmbGeneros";
            this.cmbGeneros.Size = new System.Drawing.Size(323, 21);
            this.cmbGeneros.TabIndex = 0;
            this.cmbGeneros.Text = "Seleccione un género...";
            // 
            // frmRegistrarVisualizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(388, 267);
            this.Controls.Add(this.grpRegistrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarVisualizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Visualizaciones";
            this.Load += new System.EventHandler(this.frmRegistrarVisualizaciones_Load);
            this.grpRegistrar.ResumeLayout(false);
            this.grpRegistrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegistrar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtCantidadVisualizaciones;
        private System.Windows.Forms.Label lblTituloCantVisualizaciones;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbGeneros;
    }
}