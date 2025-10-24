namespace PlataformaMovieInsight
{
    partial class frmConsultaGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaGenero));
            this.grpSeleccioneGénero = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnConsultarGenero = new System.Windows.Forms.Button();
            this.lblTituloDescripcion = new System.Windows.Forms.Label();
            this.lblTituloCodigo = new System.Windows.Forms.Label();
            this.cmbListadoGeneros = new System.Windows.Forms.ComboBox();
            this.grpSeleccioneGénero.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSeleccioneGénero
            // 
            this.grpSeleccioneGénero.Controls.Add(this.lblDescripcion);
            this.grpSeleccioneGénero.Controls.Add(this.lblCodigo);
            this.grpSeleccioneGénero.Controls.Add(this.btnConsultarGenero);
            this.grpSeleccioneGénero.Controls.Add(this.lblTituloDescripcion);
            this.grpSeleccioneGénero.Controls.Add(this.lblTituloCodigo);
            this.grpSeleccioneGénero.Controls.Add(this.cmbListadoGeneros);
            this.grpSeleccioneGénero.ForeColor = System.Drawing.Color.White;
            this.grpSeleccioneGénero.Location = new System.Drawing.Point(7, 8);
            this.grpSeleccioneGénero.Name = "grpSeleccioneGénero";
            this.grpSeleccioneGénero.Size = new System.Drawing.Size(328, 334);
            this.grpSeleccioneGénero.TabIndex = 0;
            this.grpSeleccioneGénero.TabStop = false;
            this.grpSeleccioneGénero.Text = "Porfavor complete los campos";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(141, 136);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(161, 134);
            this.lblDescripcion.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(142, 78);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(161, 20);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConsultarGenero
            // 
            this.btnConsultarGenero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarGenero.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarGenero.Location = new System.Drawing.Point(23, 283);
            this.btnConsultarGenero.Name = "btnConsultarGenero";
            this.btnConsultarGenero.Size = new System.Drawing.Size(282, 29);
            this.btnConsultarGenero.TabIndex = 3;
            this.btnConsultarGenero.Text = "Consultar género seleccionado";
            this.btnConsultarGenero.UseVisualStyleBackColor = true;
            this.btnConsultarGenero.Click += new System.EventHandler(this.btnConsultarGenero_Click);
            // 
            // lblTituloDescripcion
            // 
            this.lblTituloDescripcion.AutoSize = true;
            this.lblTituloDescripcion.BackColor = System.Drawing.Color.White;
            this.lblTituloDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblTituloDescripcion.Location = new System.Drawing.Point(23, 136);
            this.lblTituloDescripcion.Name = "lblTituloDescripcion";
            this.lblTituloDescripcion.Size = new System.Drawing.Size(90, 20);
            this.lblTituloDescripcion.TabIndex = 2;
            this.lblTituloDescripcion.Text = "Descripción:";
            // 
            // lblTituloCodigo
            // 
            this.lblTituloCodigo.AutoSize = true;
            this.lblTituloCodigo.BackColor = System.Drawing.Color.White;
            this.lblTituloCodigo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblTituloCodigo.Location = new System.Drawing.Point(24, 78);
            this.lblTituloCodigo.Name = "lblTituloCodigo";
            this.lblTituloCodigo.Size = new System.Drawing.Size(61, 20);
            this.lblTituloCodigo.TabIndex = 1;
            this.lblTituloCodigo.Text = "Código:";
            // 
            // cmbListadoGeneros
            // 
            this.cmbListadoGeneros.FormattingEnabled = true;
            this.cmbListadoGeneros.Location = new System.Drawing.Point(23, 24);
            this.cmbListadoGeneros.Name = "cmbListadoGeneros";
            this.cmbListadoGeneros.Size = new System.Drawing.Size(282, 25);
            this.cmbListadoGeneros.TabIndex = 0;
            this.cmbListadoGeneros.Text = "Seleccione un género...";
            // 
            // frmConsultaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(345, 354);
            this.Controls.Add(this.grpSeleccioneGénero);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultaGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulte su género";
            this.Load += new System.EventHandler(this.frmConsultaGenero_Load);
            this.grpSeleccioneGénero.ResumeLayout(false);
            this.grpSeleccioneGénero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSeleccioneGénero;
        private System.Windows.Forms.ComboBox cmbListadoGeneros;
        private System.Windows.Forms.Label lblTituloCodigo;
        private System.Windows.Forms.Button btnConsultarGenero;
        private System.Windows.Forms.Label lblTituloDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
    }
}