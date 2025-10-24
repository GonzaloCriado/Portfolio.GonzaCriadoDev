namespace PlataformaMovieInsight
{
    partial class frmListadoGeneros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoGeneros));
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblCantidadGenero = new System.Windows.Forms.Label();
            this.dgvListadoGeneros = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoGeneros)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.btnListar);
            this.grpListado.Controls.Add(this.lblCantidadGenero);
            this.grpListado.Controls.Add(this.dgvListadoGeneros);
            this.grpListado.ForeColor = System.Drawing.Color.White;
            this.grpListado.Location = new System.Drawing.Point(15, 11);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(500, 343);
            this.grpListado.TabIndex = 0;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Mostrar Listado";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.Black;
            this.btnListar.Location = new System.Drawing.Point(39, 300);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(415, 29);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar géneros";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblCantidadGenero
            // 
            this.lblCantidadGenero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidadGenero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadGenero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadGenero.ForeColor = System.Drawing.Color.Black;
            this.lblCantidadGenero.Location = new System.Drawing.Point(293, 259);
            this.lblCantidadGenero.Name = "lblCantidadGenero";
            this.lblCantidadGenero.Size = new System.Drawing.Size(161, 20);
            this.lblCantidadGenero.TabIndex = 2;
            this.lblCantidadGenero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvListadoGeneros
            // 
            this.dgvListadoGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoGeneros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoGeneros.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoGeneros.Location = new System.Drawing.Point(9, 23);
            this.dgvListadoGeneros.Name = "dgvListadoGeneros";
            this.dgvListadoGeneros.Size = new System.Drawing.Size(483, 212);
            this.dgvListadoGeneros.TabIndex = 0;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Código";
            this.Col1.Name = "Col1";
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Nombre";
            this.Col2.Name = "Col2";
            // 
            // Col3
            // 
            this.Col3.HeaderText = "Descripcion";
            this.Col3.Name = "Col3";
            // 
            // frmListadoGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(527, 369);
            this.Controls.Add(this.grpListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoGeneros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de géneros";
            this.grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoGeneros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.DataGridView dgvListadoGeneros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.Label lblCantidadGenero;
        private System.Windows.Forms.Button btnListar;
    }
}