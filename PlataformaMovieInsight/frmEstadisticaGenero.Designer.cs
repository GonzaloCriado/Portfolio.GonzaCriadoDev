namespace PlataformaMovieInsight
{
    partial class frmEstadisticaGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticaGenero));
            this.grpEstadisticaGenero = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvEstadisticasGenero = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEstadisticaGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticasGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEstadisticaGenero
            // 
            this.grpEstadisticaGenero.Controls.Add(this.btnListar);
            this.grpEstadisticaGenero.Controls.Add(this.dgvEstadisticasGenero);
            this.grpEstadisticaGenero.ForeColor = System.Drawing.Color.White;
            this.grpEstadisticaGenero.Location = new System.Drawing.Point(12, 12);
            this.grpEstadisticaGenero.Name = "grpEstadisticaGenero";
            this.grpEstadisticaGenero.Size = new System.Drawing.Size(592, 339);
            this.grpEstadisticaGenero.TabIndex = 1;
            this.grpEstadisticaGenero.TabStop = false;
            this.grpEstadisticaGenero.Text = "Por género";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.Black;
            this.btnListar.Location = new System.Drawing.Point(390, 290);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(184, 30);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvEstadisticasGenero
            // 
            this.dgvEstadisticasGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticasGenero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstadisticasGenero.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstadisticasGenero.Location = new System.Drawing.Point(21, 28);
            this.dgvEstadisticasGenero.Name = "dgvEstadisticasGenero";
            this.dgvEstadisticasGenero.Size = new System.Drawing.Size(553, 245);
            this.dgvEstadisticasGenero.TabIndex = 0;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Género";
            this.Col1.Name = "Col1";
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Total Visualizaciones";
            this.Col2.Name = "Col2";
            // 
            // Col3
            // 
            this.Col3.HeaderText = "Promedio";
            this.Col3.Name = "Col3";
            // 
            // Col4
            // 
            this.Col4.HeaderText = "Mes más visto";
            this.Col4.Name = "Col4";
            // 
            // Col5
            // 
            this.Col5.HeaderText = "Mes menos visto";
            this.Col5.Name = "Col5";
            // 
            // frmEstadisticaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(619, 363);
            this.Controls.Add(this.grpEstadisticaGenero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstadisticaGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica por Género";
            this.grpEstadisticaGenero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticasGenero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEstadisticaGenero;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvEstadisticasGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
    }
}