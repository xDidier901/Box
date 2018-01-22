namespace BoxManager.Interfaces
{
    partial class CrearTorneo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearTorneo));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.comboBoxDivisiones = new System.Windows.Forms.ComboBox();
            this.rbFemenil = new System.Windows.Forms.RadioButton();
            this.rbVaronil = new System.Windows.Forms.RadioButton();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.textBoxNombreT = new System.Windows.Forms.TextBox();
            this.labelDivisiones = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelRama = new System.Windows.Forms.Label();
            this.labelNombreT = new System.Windows.Forms.Label();
            this.dgDisponibles = new System.Windows.Forms.DataGridView();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSeleccionados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelDisponibles = new System.Windows.Forms.Label();
            this.labelSeleccionados = new System.Windows.Forms.Label();
            this.buttonCrearT = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new BoxManager.Reportes.GraficaDataSetTableAdapters.TableAdapterManager();
            this.progressBarPeleas = new System.Windows.Forms.ProgressBar();
            this.reporteGraficaTableAdapter1 = new BoxManager.Reportes.GraficaDataSetTableAdapters.ReporteGraficaTableAdapter();
            this.labelCreandoRandom = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSeleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(360, -4);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(225, 63);
            this.labelTitulo.TabIndex = 17;
            this.labelTitulo.Text = "Torneos";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(8, 8);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(82, 42);
            this.buttonMenu.TabIndex = 18;
            this.buttonMenu.Text = "Menú";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BoxManager.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(154, 242);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(301, 145);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 26;
            this.pictureBoxLogo.TabStop = false;
            // 
            // comboBoxDivisiones
            // 
            this.comboBoxDivisiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDivisiones.FormattingEnabled = true;
            this.comboBoxDivisiones.Location = new System.Drawing.Point(102, 133);
            this.comboBoxDivisiones.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxDivisiones.Name = "comboBoxDivisiones";
            this.comboBoxDivisiones.Size = new System.Drawing.Size(329, 21);
            this.comboBoxDivisiones.TabIndex = 34;
            this.comboBoxDivisiones.SelectedIndexChanged += new System.EventHandler(this.comboBoxDivisiones_SelectedIndexChanged);
            // 
            // rbFemenil
            // 
            this.rbFemenil.AutoSize = true;
            this.rbFemenil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFemenil.Enabled = false;
            this.rbFemenil.Location = new System.Drawing.Point(295, 86);
            this.rbFemenil.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbFemenil.Name = "rbFemenil";
            this.rbFemenil.Size = new System.Drawing.Size(61, 17);
            this.rbFemenil.TabIndex = 36;
            this.rbFemenil.Text = "Femenil";
            this.rbFemenil.UseVisualStyleBackColor = true;
            this.rbFemenil.CheckedChanged += new System.EventHandler(this.rbFemenil_CheckedChanged);
            // 
            // rbVaronil
            // 
            this.rbVaronil.AutoSize = true;
            this.rbVaronil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbVaronil.Enabled = false;
            this.rbVaronil.Location = new System.Drawing.Point(169, 84);
            this.rbVaronil.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbVaronil.Name = "rbVaronil";
            this.rbVaronil.Size = new System.Drawing.Size(57, 17);
            this.rbVaronil.TabIndex = 35;
            this.rbVaronil.Text = "Varonil";
            this.rbVaronil.UseVisualStyleBackColor = true;
            this.rbVaronil.CheckedChanged += new System.EventHandler(this.rbVaronil_CheckedChanged);
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(102, 109);
            this.comboBoxCategorias.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(329, 21);
            this.comboBoxCategorias.TabIndex = 33;
            this.comboBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategorias_SelectedIndexChanged);
            // 
            // textBoxNombreT
            // 
            this.textBoxNombreT.Location = new System.Drawing.Point(102, 62);
            this.textBoxNombreT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNombreT.Name = "textBoxNombreT";
            this.textBoxNombreT.Size = new System.Drawing.Size(329, 20);
            this.textBoxNombreT.TabIndex = 32;
            this.textBoxNombreT.TextChanged += new System.EventHandler(this.textBoxNombreT_TextChanged);
            // 
            // labelDivisiones
            // 
            this.labelDivisiones.AutoSize = true;
            this.labelDivisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivisiones.Location = new System.Drawing.Point(21, 137);
            this.labelDivisiones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDivisiones.Name = "labelDivisiones";
            this.labelDivisiones.Size = new System.Drawing.Size(70, 17);
            this.labelDivisiones.TabIndex = 31;
            this.labelDivisiones.Text = "División:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(9, 109);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(83, 17);
            this.labelCategoria.TabIndex = 30;
            this.labelCategoria.Text = "Categoría:";
            // 
            // labelRama
            // 
            this.labelRama.AutoSize = true;
            this.labelRama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRama.Location = new System.Drawing.Point(37, 84);
            this.labelRama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRama.Name = "labelRama";
            this.labelRama.Size = new System.Drawing.Size(54, 17);
            this.labelRama.TabIndex = 29;
            this.labelRama.Text = "Rama:";
            // 
            // labelNombreT
            // 
            this.labelNombreT.AutoSize = true;
            this.labelNombreT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreT.Location = new System.Drawing.Point(23, 62);
            this.labelNombreT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreT.Name = "labelNombreT";
            this.labelNombreT.Size = new System.Drawing.Size(69, 17);
            this.labelNombreT.TabIndex = 28;
            this.labelNombreT.Text = "Nombre:";
            // 
            // dgDisponibles
            // 
            this.dgDisponibles.AllowUserToAddRows = false;
            this.dgDisponibles.AllowUserToDeleteRows = false;
            this.dgDisponibles.AllowUserToResizeColumns = false;
            this.dgDisponibles.AllowUserToResizeRows = false;
            this.dgDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDisponibles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID1,
            this.Nombre1});
            this.dgDisponibles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgDisponibles.Location = new System.Drawing.Point(24, 242);
            this.dgDisponibles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgDisponibles.Name = "dgDisponibles";
            this.dgDisponibles.ReadOnly = true;
            this.dgDisponibles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgDisponibles.RowHeadersVisible = false;
            this.dgDisponibles.RowTemplate.Height = 24;
            this.dgDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDisponibles.Size = new System.Drawing.Size(126, 273);
            this.dgDisponibles.TabIndex = 37;
            // 
            // ID1
            // 
            this.ID1.HeaderText = "ID";
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Width = 43;
            // 
            // Nombre1
            // 
            this.Nombre1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre1.HeaderText = "Nombre";
            this.Nombre1.Name = "Nombre1";
            this.Nombre1.ReadOnly = true;
            this.Nombre1.Width = 69;
            // 
            // dgSeleccionados
            // 
            this.dgSeleccionados.AllowUserToAddRows = false;
            this.dgSeleccionados.AllowUserToDeleteRows = false;
            this.dgSeleccionados.AllowUserToResizeColumns = false;
            this.dgSeleccionados.AllowUserToResizeRows = false;
            this.dgSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgSeleccionados.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre});
            this.dgSeleccionados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgSeleccionados.Location = new System.Drawing.Point(459, 242);
            this.dgSeleccionados.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgSeleccionados.Name = "dgSeleccionados";
            this.dgSeleccionados.ReadOnly = true;
            this.dgSeleccionados.RowHeadersVisible = false;
            this.dgSeleccionados.RowTemplate.Height = 24;
            this.dgSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSeleccionados.Size = new System.Drawing.Size(126, 273);
            this.dgSeleccionados.TabIndex = 38;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(24, 521);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(126, 32);
            this.buttonAgregar.TabIndex = 39;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(459, 521);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(126, 32);
            this.buttonEliminar.TabIndex = 40;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelDisponibles
            // 
            this.labelDisponibles.AutoSize = true;
            this.labelDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisponibles.Location = new System.Drawing.Point(19, 214);
            this.labelDisponibles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDisponibles.Name = "labelDisponibles";
            this.labelDisponibles.Size = new System.Drawing.Size(223, 25);
            this.labelDisponibles.TabIndex = 41;
            this.labelDisponibles.Text = "Boxeadores Disponibles";
            this.labelDisponibles.Click += new System.EventHandler(this.labelDisponibles_Click);
            // 
            // labelSeleccionados
            // 
            this.labelSeleccionados.AutoSize = true;
            this.labelSeleccionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccionados.Location = new System.Drawing.Point(334, 214);
            this.labelSeleccionados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSeleccionados.Name = "labelSeleccionados";
            this.labelSeleccionados.Size = new System.Drawing.Size(251, 25);
            this.labelSeleccionados.TabIndex = 42;
            this.labelSeleccionados.Text = "Boxeadores Seleccionados";
            // 
            // buttonCrearT
            // 
            this.buttonCrearT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearT.Enabled = false;
            this.buttonCrearT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearT.Location = new System.Drawing.Point(191, 495);
            this.buttonCrearT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCrearT.Name = "buttonCrearT";
            this.buttonCrearT.Size = new System.Drawing.Size(221, 96);
            this.buttonCrearT.TabIndex = 43;
            this.buttonCrearT.Text = "Crear Torneo";
            this.buttonCrearT.UseVisualStyleBackColor = true;
            this.buttonCrearT.Click += new System.EventHandler(this.buttonCrearT_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(21, 163);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(145, 32);
            this.buttonLimpiar.TabIndex = 44;
            this.buttonLimpiar.Text = "Limpiar Campos";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = BoxManager.Reportes.GraficaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // progressBarPeleas
            // 
            this.progressBarPeleas.Location = new System.Drawing.Point(191, 451);
            this.progressBarPeleas.Name = "progressBarPeleas";
            this.progressBarPeleas.Size = new System.Drawing.Size(221, 23);
            this.progressBarPeleas.Step = 3;
            this.progressBarPeleas.TabIndex = 45;
            this.progressBarPeleas.Visible = false;
            // 
            // reporteGraficaTableAdapter1
            // 
            this.reporteGraficaTableAdapter1.ClearBeforeFill = true;
            // 
            // labelCreandoRandom
            // 
            this.labelCreandoRandom.AutoSize = true;
            this.labelCreandoRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreandoRandom.Location = new System.Drawing.Point(177, 423);
            this.labelCreandoRandom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreandoRandom.Name = "labelCreandoRandom";
            this.labelCreandoRandom.Size = new System.Drawing.Size(255, 25);
            this.labelCreandoRandom.TabIndex = 46;
            this.labelCreandoRandom.Text = "Creando peleas aleatorias...";
            this.labelCreandoRandom.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CrearTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 603);
            this.Controls.Add(this.labelCreandoRandom);
            this.Controls.Add(this.progressBarPeleas);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonCrearT);
            this.Controls.Add(this.rbFemenil);
            this.Controls.Add(this.labelSeleccionados);
            this.Controls.Add(this.labelDisponibles);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.dgSeleccionados);
            this.Controls.Add(this.dgDisponibles);
            this.Controls.Add(this.comboBoxDivisiones);
            this.Controls.Add(this.rbVaronil);
            this.Controls.Add(this.comboBoxCategorias);
            this.Controls.Add(this.textBoxNombreT);
            this.Controls.Add(this.labelDivisiones);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelRama);
            this.Controls.Add(this.labelNombreT);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CrearTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torneo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Torneo_FormClosing);
            this.Load += new System.EventHandler(this.Torneo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSeleccionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ComboBox comboBoxDivisiones;
        private System.Windows.Forms.RadioButton rbFemenil;
        private System.Windows.Forms.RadioButton rbVaronil;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.TextBox textBoxNombreT;
        private System.Windows.Forms.Label labelDivisiones;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelRama;
        private System.Windows.Forms.Label labelNombreT;
        private System.Windows.Forms.DataGridView dgDisponibles;
        private System.Windows.Forms.DataGridView dgSeleccionados;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label labelDisponibles;
        private System.Windows.Forms.Label labelSeleccionados;
        private System.Windows.Forms.Button buttonCrearT;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre1;
        private Reportes.GraficaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ProgressBar progressBarPeleas;
        private Reportes.GraficaDataSetTableAdapters.ReporteGraficaTableAdapter reporteGraficaTableAdapter1;
        private System.Windows.Forms.Label labelCreandoRandom;
        private System.Windows.Forms.Timer timer1;
    }
}