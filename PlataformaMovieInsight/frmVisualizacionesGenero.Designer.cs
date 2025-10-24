namespace PlataformaMovieInsight
{
    partial class frmVisualizacionesGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizacionesGenero));
            this.lblTotalMinimo = new System.Windows.Forms.Label();
            this.lblTotalMaximo = new System.Windows.Forms.Label();
            this.lblTotalPromedio = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblResultadoTotal = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvDatosVisualGenero = new System.Windows.Forms.DataGridView();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVisualGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalMinimo
            // 
            this.lblTotalMinimo.BackColor = System.Drawing.Color.White;
            this.lblTotalMinimo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMinimo.Location = new System.Drawing.Point(188, 358);
            this.lblTotalMinimo.Name = "lblTotalMinimo";
            this.lblTotalMinimo.Size = new System.Drawing.Size(136, 17);
            this.lblTotalMinimo.TabIndex = 24;
            this.lblTotalMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalMaximo
            // 
            this.lblTotalMaximo.BackColor = System.Drawing.Color.White;
            this.lblTotalMaximo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMaximo.Location = new System.Drawing.Point(188, 321);
            this.lblTotalMaximo.Name = "lblTotalMaximo";
            this.lblTotalMaximo.Size = new System.Drawing.Size(136, 17);
            this.lblTotalMaximo.TabIndex = 23;
            this.lblTotalMaximo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPromedio
            // 
            this.lblTotalPromedio.BackColor = System.Drawing.Color.White;
            this.lblTotalPromedio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPromedio.Location = new System.Drawing.Point(188, 283);
            this.lblTotalPromedio.Name = "lblTotalPromedio";
            this.lblTotalPromedio.Size = new System.Drawing.Size(136, 17);
            this.lblTotalPromedio.TabIndex = 22;
            this.lblTotalPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(24, 402);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(300, 33);
            this.btnListar.TabIndex = 21;
            this.btnListar.Text = "Listar por Genero";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblResultadoTotal
            // 
            this.lblResultadoTotal.BackColor = System.Drawing.Color.White;
            this.lblResultadoTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTotal.Location = new System.Drawing.Point(188, 245);
            this.lblResultadoTotal.Name = "lblResultadoTotal";
            this.lblResultadoTotal.Size = new System.Drawing.Size(136, 17);
            this.lblResultadoTotal.TabIndex = 20;
            this.lblResultadoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.BackColor = System.Drawing.Color.White;
            this.lblMinimo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.Location = new System.Drawing.Point(21, 358);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(55, 17);
            this.lblMinimo.TabIndex = 19;
            this.lblMinimo.Text = "Minimo:";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.BackColor = System.Drawing.Color.White;
            this.lblMaximo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximo.Location = new System.Drawing.Point(21, 321);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(58, 17);
            this.lblMaximo.TabIndex = 18;
            this.lblMaximo.Text = "Maximo:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.BackColor = System.Drawing.Color.White;
            this.lblPromedio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(21, 283);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(68, 17);
            this.lblPromedio.TabIndex = 17;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(21, 245);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(128, 17);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total visualizaciones:";
            // 
            // dgvDatosVisualGenero
            // 
            this.dgvDatosVisualGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosVisualGenero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2});
            this.dgvDatosVisualGenero.Location = new System.Drawing.Point(24, 60);
            this.dgvDatosVisualGenero.Name = "dgvDatosVisualGenero";
            this.dgvDatosVisualGenero.Size = new System.Drawing.Size(300, 150);
            this.dgvDatosVisualGenero.TabIndex = 15;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(24, 17);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(300, 21);
            this.cmbGenero.TabIndex = 14;
            this.cmbGenero.Text = "Seleccione un género...";
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Mes";
            this.Col1.Name = "Col1";
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Cantidad";
            this.Col2.Name = "Col2";
            // 
            // frmVisualizacionesGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.lblTotalMinimo);
            this.Controls.Add(this.lblTotalMaximo);
            this.Controls.Add(this.lblTotalPromedio);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblResultadoTotal);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvDatosVisualGenero);
            this.Controls.Add(this.cmbGenero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisualizacionesGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizaciones por Género";
            this.Load += new System.EventHandler(this.frmVisualizacionesGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVisualGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalMinimo;
        private System.Windows.Forms.Label lblTotalMaximo;
        private System.Windows.Forms.Label lblTotalPromedio;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblResultadoTotal;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvDatosVisualGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
    }
}