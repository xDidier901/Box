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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxeadoresReport));
            this.reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteBoxeadores = new BoxManager.Reportes.ReporteBoxeadores();
            this.ReporteGraficaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GraficaDataSet = new BoxManager.Reportes.GraficaDataSet();
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
            this.reportGrafica = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteGraficaTableAdapter = new BoxManager.Reportes.GraficaDataSetTableAdapters.ReporteGraficaTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteBoxeadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteGraficaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaDataSet)).BeginInit();
            this.groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // ReporteGraficaBindingSource
            // 
            this.ReporteGraficaBindingSource.DataMember = "ReporteGrafica";
            this.ReporteGraficaBindingSource.DataSource = this.GraficaDataSet;
            // 
            // GraficaDataSet
            // 
            this.GraficaDataSet.DataSetName = "GraficaDataSet";
            this.GraficaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportBoxeadores
            // 
            reportDataSource1.Name = "BoxeadoresReport";
            reportDataSource1.Value = this.reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource;
            this.reportBoxeadores.LocalReport.DataSources.Add(reportDataSource1);
            this.reportBoxeadores.LocalReport.ReportEmbeddedResource = "BoxManager.Reportes.ReportBox.rdlc";
            this.reportBoxeadores.Location = new System.Drawing.Point(9, 65);
            this.reportBoxeadores.Margin = new System.Windows.Forms.Padding(2);
            this.reportBoxeadores.Name = "reportBoxeadores";
            this.reportBoxeadores.Size = new System.Drawing.Size(681, 496);
            this.reportBoxeadores.TabIndex = 0;
            // 
            // labelCategorias
            // 
            this.labelCategorias.AutoSize = true;
            this.labelCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorias.Location = new System.Drawing.Point(306, 11);
            this.labelCategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategorias.Name = "labelCategorias";
            this.labelCategorias.Size = new System.Drawing.Size(366, 39);
            this.labelCategorias.TabIndex = 20;
            this.labelCategorias.Text = "Listado de boxeadores";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(9, 10);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(82, 41);
            this.buttonMenu.TabIndex = 8;
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
            this.groupBoxFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltros.Location = new System.Drawing.Point(694, 60);
            this.groupBoxFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFiltros.Size = new System.Drawing.Size(388, 229);
            this.groupBoxFiltros.TabIndex = 22;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            // 
            // buttonGenerarR
            // 
            this.buttonGenerarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerarR.Enabled = false;
            this.buttonGenerarR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarR.Location = new System.Drawing.Point(248, 183);
            this.buttonGenerarR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerarR.Name = "buttonGenerarR";
            this.buttonGenerarR.Size = new System.Drawing.Size(127, 33);
            this.buttonGenerarR.TabIndex = 6;
            this.buttonGenerarR.Text = "Generar Reporte";
            this.buttonGenerarR.UseVisualStyleBackColor = true;
            this.buttonGenerarR.Click += new System.EventHandler(this.buttonGenerarR_Click);
            // 
            // buttonReestablecer
            // 
            this.buttonReestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReestablecer.Location = new System.Drawing.Point(7, 183);
            this.buttonReestablecer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReestablecer.Name = "buttonReestablecer";
            this.buttonReestablecer.Size = new System.Drawing.Size(127, 33);
            this.buttonReestablecer.TabIndex = 7;
            this.buttonReestablecer.Text = "Reestablecer";
            this.buttonReestablecer.UseVisualStyleBackColor = true;
            this.buttonReestablecer.Click += new System.EventHandler(this.buttonReestablecer_Click);
            // 
            // comboBoxMunicipios
            // 
            this.comboBoxMunicipios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMunicipios.DisplayMember = "Nombre";
            this.comboBoxMunicipios.FormattingEnabled = true;
            this.comboBoxMunicipios.Location = new System.Drawing.Point(92, 130);
            this.comboBoxMunicipios.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMunicipios.Name = "comboBoxMunicipios";
            this.comboBoxMunicipios.Size = new System.Drawing.Size(284, 25);
            this.comboBoxMunicipios.TabIndex = 5;
            this.comboBoxMunicipios.ValueMember = "Id_Municipio";
            this.comboBoxMunicipios.Click += new System.EventHandler(this.comboBoxMunicipios_Click);
            // 
            // comboBoxDivisiones
            // 
            this.comboBoxDivisiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDivisiones.Enabled = false;
            this.comboBoxDivisiones.FormattingEnabled = true;
            this.comboBoxDivisiones.Location = new System.Drawing.Point(92, 92);
            this.comboBoxDivisiones.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDivisiones.Name = "comboBoxDivisiones";
            this.comboBoxDivisiones.Size = new System.Drawing.Size(284, 25);
            this.comboBoxDivisiones.TabIndex = 4;
            this.comboBoxDivisiones.Click += new System.EventHandler(this.comboBoxDivisiones_Click);
            // 
            // rbFemenil
            // 
            this.rbFemenil.AutoSize = true;
            this.rbFemenil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFemenil.Location = new System.Drawing.Point(174, 21);
            this.rbFemenil.Margin = new System.Windows.Forms.Padding(2);
            this.rbFemenil.Name = "rbFemenil";
            this.rbFemenil.Size = new System.Drawing.Size(82, 21);
            this.rbFemenil.TabIndex = 2;
            this.rbFemenil.Text = "Femenil";
            this.rbFemenil.UseVisualStyleBackColor = true;
            this.rbFemenil.CheckedChanged += new System.EventHandler(this.rbFemenil_CheckedChanged);
            // 
            // rbVaronil
            // 
            this.rbVaronil.AutoSize = true;
            this.rbVaronil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbVaronil.Location = new System.Drawing.Point(92, 21);
            this.rbVaronil.Margin = new System.Windows.Forms.Padding(2);
            this.rbVaronil.Name = "rbVaronil";
            this.rbVaronil.Size = new System.Drawing.Size(77, 21);
            this.rbVaronil.TabIndex = 1;
            this.rbVaronil.Text = "Varonil";
            this.rbVaronil.UseVisualStyleBackColor = true;
            this.rbVaronil.CheckedChanged += new System.EventHandler(this.rbVaronil_CheckedChanged);
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(92, 54);
            this.comboBoxCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(284, 25);
            this.comboBoxCategorias.TabIndex = 3;
            this.comboBoxCategorias.Click += new System.EventHandler(this.comboBoxCategorias_Click);
            // 
            // labelMunicipio
            // 
            this.labelMunicipio.AutoSize = true;
            this.labelMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMunicipio.Location = new System.Drawing.Point(4, 136);
            this.labelMunicipio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMunicipio.Name = "labelMunicipio";
            this.labelMunicipio.Size = new System.Drawing.Size(81, 17);
            this.labelMunicipio.TabIndex = 6;
            this.labelMunicipio.Text = "Municipio:";
            // 
            // labelDiv
            // 
            this.labelDiv.AutoSize = true;
            this.labelDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiv.Location = new System.Drawing.Point(16, 98);
            this.labelDiv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiv.Name = "labelDiv";
            this.labelDiv.Size = new System.Drawing.Size(70, 17);
            this.labelDiv.TabIndex = 5;
            this.labelDiv.Text = "División:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(9, 61);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(83, 17);
            this.labelCategoria.TabIndex = 4;
            this.labelCategoria.Text = "Categoría:";
            // 
            // labelRama
            // 
            this.labelRama.AutoSize = true;
            this.labelRama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRama.Location = new System.Drawing.Point(34, 23);
            this.labelRama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRama.Name = "labelRama";
            this.labelRama.Size = new System.Drawing.Size(54, 17);
            this.labelRama.TabIndex = 2;
            this.labelRama.Text = "Rama:";
            // 
            // reportGrafica
            // 
            reportDataSource2.Name = "Grafica";
            reportDataSource2.Value = this.ReporteGraficaBindingSource;
            this.reportGrafica.LocalReport.DataSources.Add(reportDataSource2);
            this.reportGrafica.LocalReport.ReportEmbeddedResource = "BoxManager.Reportes.ReportGrafica.rdlc";
            this.reportGrafica.Location = new System.Drawing.Point(694, 294);
            this.reportGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.reportGrafica.Name = "reportGrafica";
            this.reportGrafica.Size = new System.Drawing.Size(395, 270);
            this.reportGrafica.TabIndex = 23;
            this.reportGrafica.Load += new System.EventHandler(this.reportGrafica_Load);
            // 
            // ReporteGraficaTableAdapter
            // 
            this.ReporteGraficaTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BoxManager.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(927, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // BoxeadoresReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reportGrafica);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelCategorias);
            this.Controls.Add(this.reportBoxeadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "BoxeadoresReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteBoxeadores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Boxeadores_FormClosing);
            this.Load += new System.EventHandler(this.ReporteBoxeadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteBoxeadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteGraficaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaDataSet)).EndInit();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer reportGrafica;
        private System.Windows.Forms.BindingSource ReporteGraficaBindingSource;
        private GraficaDataSet GraficaDataSet;
        private GraficaDataSetTableAdapters.ReporteGraficaTableAdapter ReporteGraficaTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}