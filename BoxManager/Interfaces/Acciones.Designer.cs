namespace BoxManager.Interfaces
{
    partial class Acciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acciones));
            this.dgAcciones = new System.Windows.Forms.DataGridView();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelBuscarNombre = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.labelFecha1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAcciones)).BeginInit();
            this.groupBoxBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAcciones
            // 
            this.dgAcciones.AllowUserToAddRows = false;
            this.dgAcciones.AllowUserToDeleteRows = false;
            this.dgAcciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgAcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAcciones.Location = new System.Drawing.Point(9, 268);
            this.dgAcciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgAcciones.Name = "dgAcciones";
            this.dgAcciones.ReadOnly = true;
            this.dgAcciones.RowTemplate.Height = 24;
            this.dgAcciones.Size = new System.Drawing.Size(504, 363);
            this.dgAcciones.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(105, 36);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(342, 39);
            this.labelTitulo.TabIndex = 17;
            this.labelTitulo.Text = "Historial de Acciones";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(9, 10);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(82, 41);
            this.buttonMenu.TabIndex = 18;
            this.buttonMenu.Text = "Menú";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelBuscarNombre
            // 
            this.labelBuscarNombre.AutoSize = true;
            this.labelBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarNombre.Location = new System.Drawing.Point(9, 231);
            this.labelBuscarNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuscarNombre.Name = "labelBuscarNombre";
            this.labelBuscarNombre.Size = new System.Drawing.Size(180, 17);
            this.labelBuscarNombre.TabIndex = 19;
            this.labelBuscarNombre.Text = "Buscar por descripción:";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(193, 231);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(320, 20);
            this.textBoxBuscar.TabIndex = 20;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.buttonBuscar);
            this.groupBoxBusqueda.Controls.Add(this.dtpFecha2);
            this.groupBoxBusqueda.Controls.Add(this.label1);
            this.groupBoxBusqueda.Controls.Add(this.dtpFecha1);
            this.groupBoxBusqueda.Controls.Add(this.labelFecha1);
            this.groupBoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBusqueda.Location = new System.Drawing.Point(12, 87);
            this.groupBoxBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxBusqueda.Size = new System.Drawing.Size(361, 127);
            this.groupBoxBusqueda.TabIndex = 21;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Buscar por rango de fechas:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar.Location = new System.Drawing.Point(261, 49);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(82, 45);
            this.buttonBuscar.TabIndex = 22;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(122, 75);
            this.dtpFecha2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha2.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(118, 19);
            this.dtpFecha2.TabIndex = 14;
            this.dtpFecha2.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha final:";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(122, 47);
            this.dtpFecha1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(118, 19);
            this.dtpFecha1.TabIndex = 12;
            this.dtpFecha1.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // labelFecha1
            // 
            this.labelFecha1.AutoSize = true;
            this.labelFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha1.Location = new System.Drawing.Point(4, 49);
            this.labelFecha1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha1.Name = "labelFecha1";
            this.labelFecha1.Size = new System.Drawing.Size(104, 17);
            this.labelFecha1.TabIndex = 3;
            this.labelFecha1.Text = "Fecha inicial:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BoxManager.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(387, 134);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(136, 41);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 24;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Acciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 643);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.labelBuscarNombre);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.dgAcciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Acciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Acciones_FormClosing);
            this.Load += new System.EventHandler(this.Acciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAcciones)).EndInit();
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAcciones;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label labelBuscarNombre;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Label labelFecha1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}