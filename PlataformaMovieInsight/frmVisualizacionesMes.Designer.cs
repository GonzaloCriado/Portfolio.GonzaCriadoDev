namespace PlataformaMovieInsight
{
    partial class frmVisualizacionesMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizacionesMes));
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.dgvDatosVisualMes = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblResultadoTotal = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblTotalPromedio = new System.Windows.Forms.Label();
            this.lblTotalMaximo = new System.Windows.Forms.Label();
            this.lblTotalMinimo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVisualMes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(36, 25);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(300, 21);
            this.cmbMes.TabIndex = 0;
            this.cmbMes.Text = "Seleccione un mes...";
            // 
            // dgvDatosVisualMes
            // 
            this.dgvDatosVisualMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosVisualMes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2});
            this.dgvDatosVisualMes.Location = new System.Drawing.Point(36, 75);
            this.dgvDatosVisualMes.Name = "dgvDatosVisualMes";
            this.dgvDatosVisualMes.Size = new System.Drawing.Size(300, 150);
            this.dgvDatosVisualMes.TabIndex = 1;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Género";
            this.Col1.Name = "Col1";
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Cantidad";
            this.Col2.Name = "Col2";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(33, 260);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(128, 17);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total visualizaciones:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.BackColor = System.Drawing.Color.White;
            this.lblPromedio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(33, 298);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(68, 17);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.BackColor = System.Drawing.Color.White;
            this.lblMaximo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximo.Location = new System.Drawing.Point(33, 336);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(58, 17);
            this.lblMaximo.TabIndex = 4;
            this.lblMaximo.Text = "Maximo:";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.BackColor = System.Drawing.Color.White;
            this.lblMinimo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.Location = new System.Drawing.Point(33, 373);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(55, 17);
            this.lblMinimo.TabIndex = 5;
            this.lblMinimo.Text = "Minimo:";
            // 
            // lblResultadoTotal
            // 
            this.lblResultadoTotal.BackColor = System.Drawing.Color.White;
            this.lblResultadoTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTotal.Location = new System.Drawing.Point(200, 260);
            this.lblResultadoTotal.Name = "lblResultadoTotal";
            this.lblResultadoTotal.Size = new System.Drawing.Size(136, 17);
            this.lblResultadoTotal.TabIndex = 6;
            this.lblResultadoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(36, 420);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(300, 33);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar por Mes";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblTotalPromedio
            // 
            this.lblTotalPromedio.BackColor = System.Drawing.Color.White;
            this.lblTotalPromedio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPromedio.Location = new System.Drawing.Point(200, 298);
            this.lblTotalPromedio.Name = "lblTotalPromedio";
            this.lblTotalPromedio.Size = new System.Drawing.Size(136, 17);
            this.lblTotalPromedio.TabIndex = 11;
            this.lblTotalPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalMaximo
            // 
            this.lblTotalMaximo.BackColor = System.Drawing.Color.White;
            this.lblTotalMaximo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMaximo.Location = new System.Drawing.Point(200, 336);
            this.lblTotalMaximo.Name = "lblTotalMaximo";
            this.lblTotalMaximo.Size = new System.Drawing.Size(136, 17);
            this.lblTotalMaximo.TabIndex = 12;
            this.lblTotalMaximo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalMinimo
            // 
            this.lblTotalMinimo.BackColor = System.Drawing.Color.White;
            this.lblTotalMinimo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMinimo.Location = new System.Drawing.Point(200, 373);
            this.lblTotalMinimo.Name = "lblTotalMinimo";
            this.lblTotalMinimo.Size = new System.Drawing.Size(136, 17);
            this.lblTotalMinimo.TabIndex = 13;
            this.lblTotalMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmVisualizacionesMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(368, 472);
            this.Controls.Add(this.lblTotalMinimo);
            this.Controls.Add(this.lblTotalMaximo);
            this.Controls.Add(this.lblTotalPromedio);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblResultadoTotal);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvDatosVisualMes);
            this.Controls.Add(this.cmbMes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisualizacionesMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizaciones por Mes";
            this.Load += new System.EventHandler(this.frmVisualizacionesMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVisualMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.DataGridView dgvDatosVisualMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblResultadoTotal;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblTotalPromedio;
        private System.Windows.Forms.Label lblTotalMaximo;
        private System.Windows.Forms.Label lblTotalMinimo;
    }
}