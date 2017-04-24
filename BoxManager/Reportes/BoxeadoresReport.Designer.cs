namespace BoxManager.Reportes
{
    partial class BoxeadoresReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxeadoresReport));
            this.reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteBoxeadores = new BoxManager.Reportes.ReporteBoxeadores();
            this.reportBoxeadores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.labelCategorias = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.reporteBoxeadoresPorCategoriaDivisionMunicipioTableAdapter = new BoxManager.Reportes.ReporteBoxeadoresTableAdapters.reporteBoxeadoresPorCategoriaDivisionMunicipioTableAdapter();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.buttonGenerarR = new System.Windows.Forms.Button();
            this.buttonReestablecer = new System.Windows.Forms.Button();
            this.comboBoxMunicipios = new System.Windows.Forms.ComboBox();
            this.comboBoxDivisiones = new System.Windows.Forms.ComboBox();
            this.rbFemenil = new System.Windows.Forms.RadioButton();
            this.rbVaronil = new System.Windows.Forms.RadioButton();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.labelMunicipio = new System.Windows.Forms.Label();
            this.labelDiv = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelRama = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteBoxeadores)).BeginInit();
            this.groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource
            // 
            this.reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource.DataMember = "reporteBoxeadoresPorCategoriaDivisionMunicipio";
            this.reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource.DataSource = this.ReporteBoxeadores;
            // 
            // ReporteBoxeadores
            // 
            this.ReporteBoxeadores.DataSetName = "ReporteBoxeadores";
            this.ReporteBoxeadores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportBoxeadores
            // 
            reportDataSource1.Name = "BoxeadoresReport";
            reportDataSource1.Value = this.reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource;
            this.reportBoxeadores.LocalReport.DataSources.Add(reportDataSource1);
            this.reportBoxeadores.LocalReport.ReportEmbeddedResource = "BoxManager.Reportes.ReportBox.rdlc";
            this.reportBoxeadores.Location = new System.Drawing.Point(12, 80);
            this.reportBoxeadores.Name = "reportBoxeadores";
            this.reportBoxeadores.Size = new System.Drawing.Size(907, 610);
            this.reportBoxeadores.TabIndex = 0;
            // 
            // labelCategorias
            // 
            this.labelCategorias.AutoSize = true;
            this.labelCategorias.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorias.Location = new System.Drawing.Point(408, 14);
            this.labelCategorias.Name = "labelCategorias";
            this.labelCategorias.Size = new System.Drawing.Size(478, 49);
            this.labelCategorias.TabIndex = 20;
            this.labelCategorias.Text = "Listado de boxeadores";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(109, 51);
            this.buttonMenu.TabIndex = 21;
            this.buttonMenu.Text = "Menú";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // reporteBoxeadoresPorCategoriaDivisionMunicipioTableAdapter
            // 
            this.reporteBoxeadoresPorCategoriaDivisionMunicipioTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.buttonGenerarR);
            this.groupBoxFiltros.Controls.Add(this.buttonReestablecer);
            this.groupBoxFiltros.Controls.Add(this.comboBoxMunicipios);
            this.groupBoxFiltros.Controls.Add(this.comboBoxDivisiones);
            this.groupBoxFiltros.Controls.Add(this.rbFemenil);
            this.groupBoxFiltros.Controls.Add(this.rbVaronil);
            this.groupBoxFiltros.Controls.Add(this.comboBoxCategorias);
            this.groupBoxFiltros.Controls.Add(this.labelMunicipio);
            this.groupBoxFiltros.Controls.Add(this.labelDiv);
            this.groupBoxFiltros.Controls.Add(this.labelCategoria);
            this.groupBoxFiltros.Controls.Add(this.labelRama);
            this.groupBoxFiltros.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltros.Location = new System.Drawing.Point(925, 157);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(518, 282);
            this.groupBoxFiltros.TabIndex = 22;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            // 
            // buttonGenerarR
            // 
            this.buttonGenerarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerarR.Enabled = false;
            this.buttonGenerarR.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarR.Location = new System.Drawing.Point(331, 225);
            this.buttonGenerarR.Name = "buttonGenerarR";
            this.buttonGenerarR.Size = new System.Drawing.Size(169, 41);
            this.buttonGenerarR.TabIndex = 23;
            this.buttonGenerarR.Text = "Generar Reporte";
            this.buttonGenerarR.UseVisualStyleBackColor = true;
            this.buttonGenerarR.Click += new System.EventHandler(this.buttonGenerarR_Click);
            // 
            // buttonReestablecer
            // 
            this.buttonReestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReestablecer.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReestablecer.Location = new System.Drawing.Point(9, 225);
            this.buttonReestablecer.Name = "buttonReestablecer";
            this.buttonReestablecer.Size = new System.Drawing.Size(169, 41);
            this.buttonReestablecer.TabIndex = 24;
            this.buttonReestablecer.Text = "Reestablecer";
            this.buttonReestablecer.UseVisualStyleBackColor = true;
            this.buttonReestablecer.Click += new System.EventHandler(this.buttonReestablecer_Click);
            // 
            // comboBoxMunicipios
            // 
            this.comboBoxMunicipios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMunicipios.DisplayMember = "Nombre";
            this.comboBoxMunicipios.FormattingEnabled = true;
            this.comboBoxMunicipios.Location = new System.Drawing.Point(122, 160);
            this.comboBoxMunicipios.Name = "comboBoxMunicipios";
            this.comboBoxMunicipios.Size = new System.Drawing.Size(378, 28);
            this.comboBoxMunicipios.TabIndex = 13;
            this.comboBoxMunicipios.ValueMember = "Id_Municipio";
            this.comboBoxMunicipios.Click += new System.EventHandler(this.comboBoxMunicipios_Click);
            // 
            // comboBoxDivisiones
            // 
            this.comboBoxDivisiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDivisiones.Enabled = false;
            this.comboBoxDivisiones.FormattingEnabled = true;
            this.comboBoxDivisiones.Location = new System.Drawing.Point(122, 113);
            this.comboBoxDivisiones.Name = "comboBoxDivisiones";
            this.comboBoxDivisiones.Size = new System.Drawing.Size(378, 28);
            this.comboBoxDivisiones.TabIndex = 10;
            this.comboBoxDivisiones.Click += new System.EventHandler(this.comboBoxDivisiones_Click);
            // 
            // rbFemenil
            // 
            this.rbFemenil.AutoSize = true;
            this.rbFemenil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFemenil.Location = new System.Drawing.Point(232, 26);
            this.rbFemenil.Name = "rbFemenil";
            this.rbFemenil.Size = new System.Drawing.Size(101, 24);
            this.rbFemenil.TabIndex = 11;
            this.rbFemenil.Text = "Femenil";
            this.rbFemenil.UseVisualStyleBackColor = true;
            this.rbFemenil.CheckedChanged += new System.EventHandler(this.rbFemenil_CheckedChanged);
            // 
            // rbVaronil
            // 
            this.rbVaronil.AutoSize = true;
            this.rbVaronil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbVaronil.Location = new System.Drawing.Point(122, 26);
            this.rbVaronil.Name = "rbVaronil";
            this.rbVaronil.Size = new System.Drawing.Size(93, 24);
            this.rbVaronil.TabIndex = 10;
            this.rbVaronil.Text = "Varonil";
            this.rbVaronil.UseVisualStyleBackColor = true;
            this.rbVaronil.CheckedChanged += new System.EventHandler(this.rbVaronil_CheckedChanged);
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(122, 67);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(378, 28);
            this.comboBoxCategorias.TabIndex = 9;
            this.comboBoxCategorias.Click += new System.EventHandler(this.comboBoxCategorias_Click);
            // 
            // labelMunicipio
            // 
            this.labelMunicipio.AutoSize = true;
            this.labelMunicipio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMunicipio.Location = new System.Drawing.Point(5, 168);
            this.labelMunicipio.Name = "labelMunicipio";
            this.labelMunicipio.Size = new System.Drawing.Size(104, 20);
            this.labelMunicipio.TabIndex = 6;
            this.labelMunicipio.Text = "Municipio:";
            // 
            // labelDiv
            // 
            this.labelDiv.AutoSize = true;
            this.labelDiv.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiv.Location = new System.Drawing.Point(22, 121);
            this.labelDiv.Name = "labelDiv";
            this.labelDiv.Size = new System.Drawing.Size(87, 20);
            this.labelDiv.TabIndex = 5;
            this.labelDiv.Text = "División:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(12, 75);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(99, 20);
            this.labelCategoria.TabIndex = 4;
            this.labelCategoria.Text = "Categoría:";
            // 
            // labelRama
            // 
            this.labelRama.AutoSize = true;
            this.labelRama.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRama.Location = new System.Drawing.Point(45, 28);
            this.labelRama.Name = "labelRama";
            this.labelRama.Size = new System.Drawing.Size(64, 20);
            this.labelRama.TabIndex = 2;
            this.labelRama.Text = "Rama:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BoxManager.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(925, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(518, 129);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 23;
            this.pictureBoxLogo.TabStop = false;
            // 
            // BoxeadoresReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 706);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelCategorias);
            this.Controls.Add(this.reportBoxeadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BoxeadoresReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteBoxeadores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Boxeadores_FormClosing);
            this.Load += new System.EventHandler(this.ReporteBoxeadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteBoxeadores)).EndInit();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportBoxeadores;
        private System.Windows.Forms.Label labelCategorias;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.BindingSource reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource;
        private ReporteBoxeadores ReporteBoxeadores;
        private ReporteBoxeadoresTableAdapters.reporteBoxeadoresPorCategoriaDivisionMunicipioTableAdapter reporteBoxeadoresPorCategoriaDivisionMunicipioTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.ComboBox comboBoxMunicipios;
        private System.Windows.Forms.ComboBox comboBoxDivisiones;
        private System.Windows.Forms.RadioButton rbFemenil;
        private System.Windows.Forms.RadioButton rbVaronil;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.Label labelMunicipio;
        private System.Windows.Forms.Label labelDiv;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelRama;
        private System.Windows.Forms.Button buttonGenerarR;
        private System.Windows.Forms.Button buttonReestablecer;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}