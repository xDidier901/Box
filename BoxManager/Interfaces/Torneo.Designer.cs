namespace BoxManager.Interfaces
{
    partial class Torneo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Torneo));
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSeleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(684, 13);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(498, 135);
            this.labelTitulo.TabIndex = 17;
            this.labelTitulo.Text = "Torneos";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(12, 13);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(123, 64);
            this.buttonMenu.TabIndex = 18;
            this.buttonMenu.Text = "Menú";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BoxManager.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(769, 130);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(287, 130);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 26;
            this.pictureBoxLogo.TabStop = false;
            // 
            // comboBoxDivisiones
            // 
            this.comboBoxDivisiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDivisiones.FormattingEnabled = true;
            this.comboBoxDivisiones.Location = new System.Drawing.Point(153, 204);
            this.comboBoxDivisiones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDivisiones.Name = "comboBoxDivisiones";
            this.comboBoxDivisiones.Size = new System.Drawing.Size(492, 28);
            this.comboBoxDivisiones.TabIndex = 34;
            this.comboBoxDivisiones.SelectedIndexChanged += new System.EventHandler(this.comboBoxDivisiones_SelectedIndexChanged);
            // 
            // rbFemenil
            // 
            this.rbFemenil.AutoSize = true;
            this.rbFemenil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFemenil.Enabled = false;
            this.rbFemenil.Location = new System.Drawing.Point(443, 132);
            this.rbFemenil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFemenil.Name = "rbFemenil";
            this.rbFemenil.Size = new System.Drawing.Size(90, 24);
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
            this.rbVaronil.Location = new System.Drawing.Point(254, 130);
            this.rbVaronil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbVaronil.Name = "rbVaronil";
            this.rbVaronil.Size = new System.Drawing.Size(83, 24);
            this.rbVaronil.TabIndex = 35;
            this.rbVaronil.Text = "Varonil";
            this.rbVaronil.UseVisualStyleBackColor = true;
            this.rbVaronil.CheckedChanged += new System.EventHandler(this.rbVaronil_CheckedChanged);
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(153, 168);
            this.comboBoxCategorias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(492, 28);
            this.comboBoxCategorias.TabIndex = 33;
            this.comboBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategorias_SelectedIndexChanged);
            // 
            // textBoxNombreT
            // 
            this.textBoxNombreT.Location = new System.Drawing.Point(153, 96);
            this.textBoxNombreT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombreT.Name = "textBoxNombreT";
            this.textBoxNombreT.Size = new System.Drawing.Size(492, 26);
            this.textBoxNombreT.TabIndex = 32;
            this.textBoxNombreT.TextChanged += new System.EventHandler(this.textBoxNombreT_TextChanged);
            // 
            // labelDivisiones
            // 
            this.labelDivisiones.AutoSize = true;
            this.labelDivisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivisiones.Location = new System.Drawing.Point(32, 211);
            this.labelDivisiones.Name = "labelDivisiones";
            this.labelDivisiones.Size = new System.Drawing.Size(103, 25);
            this.labelDivisiones.TabIndex = 31;
            this.labelDivisiones.Text = "División:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(14, 167);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(121, 25);
            this.labelCategoria.TabIndex = 30;
            this.labelCategoria.Text = "Categoría:";
            // 
            // labelRama
            // 
            this.labelRama.AutoSize = true;
            this.labelRama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRama.Location = new System.Drawing.Point(56, 130);
            this.labelRama.Name = "labelRama";
            this.labelRama.Size = new System.Drawing.Size(79, 25);
            this.labelRama.TabIndex = 29;
            this.labelRama.Text = "Rama:";
            // 
            // labelNombreT
            // 
            this.labelNombreT.AutoSize = true;
            this.labelNombreT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreT.Location = new System.Drawing.Point(35, 96);
            this.labelNombreT.Name = "labelNombreT";
            this.labelNombreT.Size = new System.Drawing.Size(100, 25);
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
            this.dgDisponibles.Location = new System.Drawing.Point(567, 355);
            this.dgDisponibles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgDisponibles.Name = "dgDisponibles";
            this.dgDisponibles.ReadOnly = true;
            this.dgDisponibles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgDisponibles.RowTemplate.Height = 24;
            this.dgDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDisponibles.Size = new System.Drawing.Size(260, 300);
            this.dgDisponibles.TabIndex = 37;
            // 
            // ID1
            // 
            this.ID1.HeaderText = "ID";
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Width = 62;
            // 
            // Nombre1
            // 
            this.Nombre1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre1.HeaderText = "Nombre";
            this.Nombre1.Name = "Nombre1";
            this.Nombre1.ReadOnly = true;
            this.Nombre1.Width = 101;
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
            this.dgSeleccionados.Location = new System.Drawing.Point(32, 355);
            this.dgSeleccionados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgSeleccionados.Name = "dgSeleccionados";
            this.dgSeleccionados.ReadOnly = true;
            this.dgSeleccionados.RowTemplate.Height = 24;
            this.dgSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSeleccionados.Size = new System.Drawing.Size(260, 300);
            this.dgSeleccionados.TabIndex = 38;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 62;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 101;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(836, 355);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(176, 50);
            this.buttonAgregar.TabIndex = 39;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(298, 355);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(169, 50);
            this.buttonEliminar.TabIndex = 40;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelDisponibles
            // 
            this.labelDisponibles.AutoSize = true;
            this.labelDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisponibles.Location = new System.Drawing.Point(559, 305);
            this.labelDisponibles.Name = "labelDisponibles";
            this.labelDisponibles.Size = new System.Drawing.Size(453, 46);
            this.labelDisponibles.TabIndex = 41;
            this.labelDisponibles.Text = "Boxeadores Disponibles";
            // 
            // labelSeleccionados
            // 
            this.labelSeleccionados.AutoSize = true;
            this.labelSeleccionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccionados.Location = new System.Drawing.Point(24, 305);
            this.labelSeleccionados.Name = "labelSeleccionados";
            this.labelSeleccionados.Size = new System.Drawing.Size(509, 46);
            this.labelSeleccionados.TabIndex = 42;
            this.labelSeleccionados.Text = "Boxeadores Seleccionados";
            // 
            // buttonCrearT
            // 
            this.buttonCrearT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearT.Enabled = false;
            this.buttonCrearT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearT.Location = new System.Drawing.Point(838, 605);
            this.buttonCrearT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCrearT.Name = "buttonCrearT";
            this.buttonCrearT.Size = new System.Drawing.Size(218, 50);
            this.buttonCrearT.TabIndex = 43;
            this.buttonCrearT.Text = "Crear Torneo";
            this.buttonCrearT.UseVisualStyleBackColor = true;
            this.buttonCrearT.Click += new System.EventHandler(this.buttonCrearT_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(298, 605);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(218, 50);
            this.buttonLimpiar.TabIndex = 44;
            this.buttonLimpiar.Text = "Limpiar Campos";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Torneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 682);
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
            this.MaximizeBox = false;
            this.Name = "Torneo";
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
    }
}