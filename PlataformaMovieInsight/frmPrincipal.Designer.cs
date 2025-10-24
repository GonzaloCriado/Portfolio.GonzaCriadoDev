namespace PlataformaMovieInsight
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnsMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaAutomáticaDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.génerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregaNuevoGeneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoGeneralGenerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeDatosDeUnGéneroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVisualizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeVisualizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.visualizacionesDeUnMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizacionesDeUnGéneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.estadísticaDeVisualizacionesPorMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticaDeVisualizacionesPorGéneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenuPrincipal
            // 
            this.mnsMenuPrincipal.BackColor = System.Drawing.Color.Black;
            this.mnsMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.génerosToolStripMenuItem,
            this.visualizacionesToolStripMenuItem});
            this.mnsMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuPrincipal.Name = "mnsMenuPrincipal";
            this.mnsMenuPrincipal.Size = new System.Drawing.Size(800, 40);
            this.mnsMenuPrincipal.TabIndex = 0;
            this.mnsMenuPrincipal.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.cargaAutomáticaDeDatosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(109, 36);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(398, 36);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // cargaAutomáticaDeDatosToolStripMenuItem
            // 
            this.cargaAutomáticaDeDatosToolStripMenuItem.Name = "cargaAutomáticaDeDatosToolStripMenuItem";
            this.cargaAutomáticaDeDatosToolStripMenuItem.Size = new System.Drawing.Size(398, 36);
            this.cargaAutomáticaDeDatosToolStripMenuItem.Text = "Carga automática de datos… ";
            this.cargaAutomáticaDeDatosToolStripMenuItem.Click += new System.EventHandler(this.cargaAutomáticaDeDatosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(395, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(398, 36);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // génerosToolStripMenuItem
            // 
            this.génerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregaNuevoGeneroToolStripMenuItem,
            this.listadoGeneralGenerosToolStripMenuItem,
            this.consultaDeDatosDeUnGéneroToolStripMenuItem1});
            this.génerosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.génerosToolStripMenuItem.Name = "génerosToolStripMenuItem";
            this.génerosToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.génerosToolStripMenuItem.Text = "Géneros";
            // 
            // agregaNuevoGeneroToolStripMenuItem
            // 
            this.agregaNuevoGeneroToolStripMenuItem.Name = "agregaNuevoGeneroToolStripMenuItem";
            this.agregaNuevoGeneroToolStripMenuItem.Size = new System.Drawing.Size(447, 36);
            this.agregaNuevoGeneroToolStripMenuItem.Text = "Agregar nuevo género…";
            this.agregaNuevoGeneroToolStripMenuItem.Click += new System.EventHandler(this.agregaNuevoGeneroToolStripMenuItem_Click);
            // 
            // listadoGeneralGenerosToolStripMenuItem
            // 
            this.listadoGeneralGenerosToolStripMenuItem.Name = "listadoGeneralGenerosToolStripMenuItem";
            this.listadoGeneralGenerosToolStripMenuItem.Size = new System.Drawing.Size(447, 36);
            this.listadoGeneralGenerosToolStripMenuItem.Text = "Listado general de géneros… ";
            this.listadoGeneralGenerosToolStripMenuItem.Click += new System.EventHandler(this.listadoGeneralGenerosToolStripMenuItem_Click_1);
            // 
            // consultaDeDatosDeUnGéneroToolStripMenuItem1
            // 
            this.consultaDeDatosDeUnGéneroToolStripMenuItem1.Name = "consultaDeDatosDeUnGéneroToolStripMenuItem1";
            this.consultaDeDatosDeUnGéneroToolStripMenuItem1.Size = new System.Drawing.Size(447, 36);
            this.consultaDeDatosDeUnGéneroToolStripMenuItem1.Text = "Consulta de datos de un género...";
            this.consultaDeDatosDeUnGéneroToolStripMenuItem1.Click += new System.EventHandler(this.consultaDeDatosDeUnGéneroToolStripMenuItem1_Click);
            // 
            // visualizacionesToolStripMenuItem
            // 
            this.visualizacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVisualizaciónToolStripMenuItem,
            this.consultaDeVisualizacionesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.visualizacionesDeUnMesToolStripMenuItem,
            this.visualizacionesDeUnGéneroToolStripMenuItem,
            this.toolStripMenuItem3,
            this.estadísticaDeVisualizacionesPorMesToolStripMenuItem,
            this.estadísticaDeVisualizacionesPorGéneroToolStripMenuItem});
            this.visualizacionesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.visualizacionesToolStripMenuItem.Name = "visualizacionesToolStripMenuItem";
            this.visualizacionesToolStripMenuItem.Size = new System.Drawing.Size(186, 36);
            this.visualizacionesToolStripMenuItem.Text = "Visualizaciones";
            // 
            // registrarVisualizaciónToolStripMenuItem
            // 
            this.registrarVisualizaciónToolStripMenuItem.Name = "registrarVisualizaciónToolStripMenuItem";
            this.registrarVisualizaciónToolStripMenuItem.Size = new System.Drawing.Size(536, 36);
            this.registrarVisualizaciónToolStripMenuItem.Text = "Registrar visualización…";
            this.registrarVisualizaciónToolStripMenuItem.Click += new System.EventHandler(this.registrarVisualizaciónToolStripMenuItem_Click);
            // 
            // consultaDeVisualizacionesToolStripMenuItem
            // 
            this.consultaDeVisualizacionesToolStripMenuItem.Name = "consultaDeVisualizacionesToolStripMenuItem";
            this.consultaDeVisualizacionesToolStripMenuItem.Size = new System.Drawing.Size(536, 36);
            this.consultaDeVisualizacionesToolStripMenuItem.Text = "Consulta de visualizaciones… ";
            this.consultaDeVisualizacionesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeVisualizacionesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(533, 6);
            // 
            // visualizacionesDeUnMesToolStripMenuItem
            // 
            this.visualizacionesDeUnMesToolStripMenuItem.Name = "visualizacionesDeUnMesToolStripMenuItem";
            this.visualizacionesDeUnMesToolStripMenuItem.Size = new System.Drawing.Size(536, 36);
            this.visualizacionesDeUnMesToolStripMenuItem.Text = "Visualizaciones de un mes…";
            this.visualizacionesDeUnMesToolStripMenuItem.Click += new System.EventHandler(this.visualizacionesDeUnMesToolStripMenuItem_Click);
            // 
            // visualizacionesDeUnGéneroToolStripMenuItem
            // 
            this.visualizacionesDeUnGéneroToolStripMenuItem.Name = "visualizacionesDeUnGéneroToolStripMenuItem";
            this.visualizacionesDeUnGéneroToolStripMenuItem.Size = new System.Drawing.Size(536, 36);
            this.visualizacionesDeUnGéneroToolStripMenuItem.Text = "Visualizaciones de un género...";
            this.visualizacionesDeUnGéneroToolStripMenuItem.Click += new System.EventHandler(this.visualizacionesDeUnGéneroToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(533, 6);
            // 
            // estadísticaDeVisualizacionesPorMesToolStripMenuItem
            // 
            this.estadísticaDeVisualizacionesPorMesToolStripMenuItem.Name = "estadísticaDeVisualizacionesPorMesToolStripMenuItem";
            this.estadísticaDeVisualizacionesPorMesToolStripMenuItem.Size = new System.Drawing.Size(536, 36);
            this.estadísticaDeVisualizacionesPorMesToolStripMenuItem.Text = "Estadística de visualizaciones por mes...";
            this.estadísticaDeVisualizacionesPorMesToolStripMenuItem.Click += new System.EventHandler(this.estadísticaDeVisualizacionesPorMesToolStripMenuItem_Click);
            // 
            // estadísticaDeVisualizacionesPorGéneroToolStripMenuItem
            // 
            this.estadísticaDeVisualizacionesPorGéneroToolStripMenuItem.Name = "estadísticaDeVisualizacionesPorGéneroToolStripMenuItem";
            this.estadísticaDeVisualizacionesPorGéneroToolStripMenuItem.Size = new System.Drawing.Size(536, 36);
            this.estadísticaDeVisualizacionesPorGéneroToolStripMenuItem.Text = "Estadística de visualizaciones por género...";
            this.estadísticaDeVisualizacionesPorGéneroToolStripMenuItem.Click += new System.EventHandler(this.estadísticaDeVisualizacionesPorGéneroToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlataformaMovieInsight.Properties.Resources.ImagenMovieInsight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsMenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMenuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "MovieInsight";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnsMenuPrincipal.ResumeLayout(false);
            this.mnsMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaAutomáticaDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem génerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregaNuevoGeneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoGeneralGenerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeDatosDeUnGéneroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visualizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVisualizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeVisualizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem visualizacionesDeUnMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizacionesDeUnGéneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem estadísticaDeVisualizacionesPorMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticaDeVisualizacionesPorGéneroToolStripMenuItem;
    }
}

