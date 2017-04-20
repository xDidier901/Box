namespace BoxManager.Interfaces
{
    partial class Boxeadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boxeadores));
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.comboBoxMunicipios = new System.Windows.Forms.ComboBox();
            this.comboBoxDivisiones = new System.Windows.Forms.ComboBox();
            this.dtpFechaN = new System.Windows.Forms.DateTimePicker();
            this.rbFemenil = new System.Windows.Forms.RadioButton();
            this.rbVaronil = new System.Windows.Forms.RadioButton();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelMunicipio = new System.Windows.Forms.Label();
            this.labelDiv = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelFechaN = new System.Windows.Forms.Label();
            this.labelRama = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.dgBoxeadores = new System.Windows.Forms.DataGridView();
            this.labelBuscarNombre = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBoxeadores)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.Enabled = false;
            this.buttonCancelar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(1048, 361);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(119, 40);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(1173, 361);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(150, 40);
            this.buttonEliminar.TabIndex = 14;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(914, 361);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(128, 40);
            this.buttonEditar.TabIndex = 13;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(752, 361);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(156, 40);
            this.buttonAgregar.TabIndex = 12;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.textBoxEdad);
            this.groupBoxDatos.Controls.Add(this.comboBoxMunicipios);
            this.groupBoxDatos.Controls.Add(this.comboBoxDivisiones);
            this.groupBoxDatos.Controls.Add(this.dtpFechaN);
            this.groupBoxDatos.Controls.Add(this.rbFemenil);
            this.groupBoxDatos.Controls.Add(this.rbVaronil);
            this.groupBoxDatos.Controls.Add(this.comboBoxCategorias);
            this.groupBoxDatos.Controls.Add(this.textBoxNombre);
            this.groupBoxDatos.Controls.Add(this.labelEdad);
            this.groupBoxDatos.Controls.Add(this.labelMunicipio);
            this.groupBoxDatos.Controls.Add(this.labelDiv);
            this.groupBoxDatos.Controls.Add(this.labelCategoria);
            this.groupBoxDatos.Controls.Add(this.labelFechaN);
            this.groupBoxDatos.Controls.Add(this.labelRama);
            this.groupBoxDatos.Controls.Add(this.labelNombre);
            this.groupBoxDatos.Enabled = false;
            this.groupBoxDatos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatos.Location = new System.Drawing.Point(22, 136);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(1301, 203);
            this.groupBoxDatos.TabIndex = 11;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos del boxeador";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Enabled = false;
            this.textBoxEdad.Location = new System.Drawing.Point(776, 104);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(78, 27);
            this.textBoxEdad.TabIndex = 14;
            // 
            // comboBoxMunicipios
            // 
            this.comboBoxMunicipios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMunicipios.DisplayMember = "Nombre";
            this.comboBoxMunicipios.FormattingEnabled = true;
            this.comboBoxMunicipios.Location = new System.Drawing.Point(776, 63);
            this.comboBoxMunicipios.Name = "comboBoxMunicipios";
            this.comboBoxMunicipios.Size = new System.Drawing.Size(437, 28);
            this.comboBoxMunicipios.TabIndex = 13;
            this.comboBoxMunicipios.ValueMember = "Id_Municipio";
            // 
            // comboBoxDivisiones
            // 
            this.comboBoxDivisiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDivisiones.FormattingEnabled = true;
            this.comboBoxDivisiones.Location = new System.Drawing.Point(775, 29);
            this.comboBoxDivisiones.Name = "comboBoxDivisiones";
            this.comboBoxDivisiones.Size = new System.Drawing.Size(438, 28);
            this.comboBoxDivisiones.TabIndex = 10;
            // 
            // dtpFechaN
            // 
            this.dtpFechaN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaN.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaN.Location = new System.Drawing.Point(210, 107);
            this.dtpFechaN.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpFechaN.Name = "dtpFechaN";
            this.dtpFechaN.Size = new System.Drawing.Size(156, 23);
            this.dtpFechaN.TabIndex = 12;
            this.dtpFechaN.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpFechaN.ValueChanged += new System.EventHandler(this.dtpFechaN_ValueChanged);
            // 
            // rbFemenil
            // 
            this.rbFemenil.AutoSize = true;
            this.rbFemenil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFemenil.Location = new System.Drawing.Point(320, 69);
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
            this.rbVaronil.Checked = true;
            this.rbVaronil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbVaronil.Location = new System.Drawing.Point(210, 69);
            this.rbVaronil.Name = "rbVaronil";
            this.rbVaronil.Size = new System.Drawing.Size(93, 24);
            this.rbVaronil.TabIndex = 10;
            this.rbVaronil.TabStop = true;
            this.rbVaronil.Text = "Varonil";
            this.rbVaronil.UseVisualStyleBackColor = true;
            this.rbVaronil.CheckedChanged += new System.EventHandler(this.rbVaronil_CheckedChanged);
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(210, 139);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(410, 28);
            this.comboBoxCategorias.TabIndex = 9;
            this.comboBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategorias_SelectedIndexChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(210, 24);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(410, 27);
            this.textBoxNombre.TabIndex = 8;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(698, 107);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(58, 20);
            this.labelEdad.TabIndex = 7;
            this.labelEdad.Text = "Edad:";
            // 
            // labelMunicipio
            // 
            this.labelMunicipio.AutoSize = true;
            this.labelMunicipio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMunicipio.Location = new System.Drawing.Point(652, 68);
            this.labelMunicipio.Name = "labelMunicipio";
            this.labelMunicipio.Size = new System.Drawing.Size(104, 20);
            this.labelMunicipio.TabIndex = 6;
            this.labelMunicipio.Text = "Municipio:";
            // 
            // labelDiv
            // 
            this.labelDiv.AutoSize = true;
            this.labelDiv.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiv.Location = new System.Drawing.Point(669, 29);
            this.labelDiv.Name = "labelDiv";
            this.labelDiv.Size = new System.Drawing.Size(87, 20);
            this.labelDiv.TabIndex = 5;
            this.labelDiv.Text = "División:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(100, 139);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(99, 20);
            this.labelCategoria.TabIndex = 4;
            this.labelCategoria.Text = "Categoría:";
            // 
            // labelFechaN
            // 
            this.labelFechaN.AutoSize = true;
            this.labelFechaN.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaN.Location = new System.Drawing.Point(6, 109);
            this.labelFechaN.Name = "labelFechaN";
            this.labelFechaN.Size = new System.Drawing.Size(193, 20);
            this.labelFechaN.TabIndex = 3;
            this.labelFechaN.Text = "Fecha de nacimiento:";
            // 
            // labelRama
            // 
            this.labelRama.AutoSize = true;
            this.labelRama.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRama.Location = new System.Drawing.Point(135, 71);
            this.labelRama.Name = "labelRama";
            this.labelRama.Size = new System.Drawing.Size(64, 20);
            this.labelRama.TabIndex = 2;
            this.labelRama.Text = "Rama:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(115, 32);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(84, 20);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(218, 379);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(479, 22);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(22, 12);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(109, 51);
            this.buttonMenu.TabIndex = 9;
            this.buttonMenu.Text = "Menú";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // dgBoxeadores
            // 
            this.dgBoxeadores.AllowUserToAddRows = false;
            this.dgBoxeadores.AllowUserToDeleteRows = false;
            this.dgBoxeadores.AllowUserToResizeColumns = false;
            this.dgBoxeadores.AllowUserToResizeRows = false;
            this.dgBoxeadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgBoxeadores.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgBoxeadores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgBoxeadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBoxeadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgBoxeadores.Location = new System.Drawing.Point(22, 422);
            this.dgBoxeadores.MultiSelect = false;
            this.dgBoxeadores.Name = "dgBoxeadores";
            this.dgBoxeadores.ReadOnly = true;
            this.dgBoxeadores.RowTemplate.Height = 24;
            this.dgBoxeadores.Size = new System.Drawing.Size(1301, 391);
            this.dgBoxeadores.TabIndex = 8;
            this.dgBoxeadores.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBoxeadores_CellEnter);
            // 
            // labelBuscarNombre
            // 
            this.labelBuscarNombre.AutoSize = true;
            this.labelBuscarNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarNombre.Location = new System.Drawing.Point(18, 379);
            this.labelBuscarNombre.Name = "labelBuscarNombre";
            this.labelBuscarNombre.Size = new System.Drawing.Size(179, 20);
            this.labelBuscarNombre.TabIndex = 0;
            this.labelBuscarNombre.Text = "Buscar por nombre:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(394, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(592, 111);
            this.labelTitulo.TabIndex = 16;
            this.labelTitulo.Text = "Boxeadores";
            // 
            // Boxeadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 828);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelBuscarNombre);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.dgBoxeadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Boxeadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boxeadores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Boxeadores_FormClosing);
            this.Load += new System.EventHandler(this.Boxeadores_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBoxeadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.ComboBox comboBoxMunicipios;
        private System.Windows.Forms.ComboBox comboBoxDivisiones;
        private System.Windows.Forms.DateTimePicker dtpFechaN;
        private System.Windows.Forms.RadioButton rbFemenil;
        private System.Windows.Forms.RadioButton rbVaronil;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelMunicipio;
        private System.Windows.Forms.Label labelDiv;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelFechaN;
        private System.Windows.Forms.Label labelRama;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.DataGridView dgBoxeadores;
        private System.Windows.Forms.Label labelBuscarNombre;
        private System.Windows.Forms.Label labelTitulo;
    }
}