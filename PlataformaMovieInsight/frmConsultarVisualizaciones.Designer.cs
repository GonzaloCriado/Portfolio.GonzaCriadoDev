namespace PlataformaMovieInsight
{
    partial class frmConsultarVisualizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarVisualizaciones));
            this.grpConsultar = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblCantVisualizaciones = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbGeneros = new System.Windows.Forms.ComboBox();
            this.grpConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConsultar
            // 
            this.grpConsultar.Controls.Add(this.btnConsultar);
            this.grpConsultar.Controls.Add(this.lblCantVisualizaciones);
            this.grpConsultar.Controls.Add(this.cmbMes);
            this.grpConsultar.Controls.Add(this.cmbGeneros);
            this.grpConsultar.ForeColor = System.Drawing.Color.White;
            this.grpConsultar.Location = new System.Drawing.Point(12, 12);
            this.grpConsultar.Name = "grpConsultar";
            this.grpConsultar.Size = new System.Drawing.Size(226, 245);
            this.grpConsultar.TabIndex = 1;
            this.grpConsultar.TabStop = false;
            this.grpConsultar.Text = "Porfavor complete los campos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(22, 187);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(181, 33);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar visualización";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblCantVisualizaciones
            // 
            this.lblCantVisualizaciones.BackColor = System.Drawing.Color.White;
            this.lblCantVisualizaciones.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantVisualizaciones.ForeColor = System.Drawing.Color.Black;
            this.lblCantVisualizaciones.Location = new System.Drawing.Point(19, 137);
            this.lblCantVisualizaciones.Name = "lblCantVisualizaciones";
            this.lblCantVisualizaciones.Size = new System.Drawing.Size(184, 23);
            this.lblCantVisualizaciones.TabIndex = 2;
            this.lblCantVisualizaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbMes
            // 
            this.cmbMes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(20, 84);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(183, 21);
            this.cmbMes.TabIndex = 1;
            this.cmbMes.Text = "Seleccione un mes...";
            // 
            // cmbGeneros
            // 
            this.cmbGeneros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGeneros.FormattingEnabled = true;
            this.cmbGeneros.Location = new System.Drawing.Point(20, 34);
            this.cmbGeneros.Name = "cmbGeneros";
            this.cmbGeneros.Size = new System.Drawing.Size(183, 21);
            this.cmbGeneros.TabIndex = 0;
            this.cmbGeneros.Text = "Seleccione un género...";
            // 
            // frmConsultarVisualizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(255, 266);
            this.Controls.Add(this.grpConsultar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarVisualizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar las visualizaciones";
            this.Load += new System.EventHandler(this.frmConsultarVisualizaciones_Load);
            this.grpConsultar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblCantVisualizaciones;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbGeneros;
    }
}