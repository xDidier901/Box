namespace BoxManager.Interfaces
{
    partial class DivisionesCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DivisionesCategorias));
            this.labelDivisiones = new System.Windows.Forms.Label();
            this.labelCategorias = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.dgDivisiones = new System.Windows.Forms.DataGridView();
            this.dgCategorias = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxDivisiones = new System.Windows.Forms.GroupBox();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.textBoxNombreDiv = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelNombreDiv = new System.Windows.Forms.Label();
            this.buttonCancelarDiv = new System.Windows.Forms.Button();
            this.buttonEliminarDiv = new System.Windows.Forms.Button();
            this.buttonEditarDiv = new System.Windows.Forms.Button();
            this.buttonAgregarDiv = new System.Windows.Forms.Button();
            this.labelBuscarDiv = new System.Windows.Forms.Label();
            this.textBoxBuscarDivision = new System.Windows.Forms.TextBox();
            this.labelBuscarNombreCat = new System.Windows.Forms.Label();
            this.textBoxBuscarCategoria = new System.Windows.Forms.TextBox();
            this.buttonCancelarCat = new System.Windows.Forms.Button();
            this.buttonEliminarCat = new System.Windows.Forms.Button();
            this.buttonEditarCat = new System.Windows.Forms.Button();
            this.buttonAgregarCat = new System.Windows.Forms.Button();
            this.groupBoxCategorias = new System.Windows.Forms.GroupBox();
            this.rbFemCat = new System.Windows.Forms.RadioButton();
            this.rbVarCat = new System.Windows.Forms.RadioButton();
            this.textBoxNombreCat = new System.Windows.Forms.TextBox();
            this.labelRamaCat = new System.Windows.Forms.Label();
            this.labelNombreCat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFiltCat = new System.Windows.Forms.ComboBox();
            this.comboBoxFiltRama = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDivisiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).BeginInit();
            this.groupBoxDivisiones.SuspendLayout();
            this.groupBoxCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDivisiones
            // 
            this.labelDivisiones.AutoSize = true;
            this.labelDivisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivisiones.Location = new System.Drawing.Point(341, 283);
            this.labelDivisiones.Name = "labelDivisiones";
            this.labelDivisiones.Size = new System.Drawing.Size(101, 25);
            this.labelDivisiones.TabIndex = 18;
            this.labelDivisiones.Text = "Divisiones";
            // 
            // labelCategorias
            // 
            this.labelCategorias.AutoSize = true;
            this.labelCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorias.Location = new System.Drawing.Point(341, 12);
            this.labelCategorias.Name = "labelCategorias";
            this.labelCategorias.Size = new System.Drawing.Size(107, 25);
            this.labelCategorias.TabIndex = 19;
            this.labelCategorias.Text = "Categorías";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(109, 51);
            this.buttonMenu.TabIndex = 20;
            this.buttonMenu.Text = "Menú";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // dgDivisiones
            // 
            this.dgDivisiones.AllowUserToAddRows = false;
            this.dgDivisiones.AllowUserToDeleteRows = false;
            this.dgDivisiones.AllowUserToResizeColumns = false;
            this.dgDivisiones.AllowUserToResizeRows = false;
            this.dgDivisiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDivisiones.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgDivisiones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgDivisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDivisiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgDivisiones.Location = new System.Drawing.Point(496, 323);
            this.dgDivisiones.MultiSelect = false;
            this.dgDivisiones.Name = "dgDivisiones";
            this.dgDivisiones.ReadOnly = true;
            this.dgDivisiones.RowHeadersVisible = false;
            this.dgDivisiones.RowTemplate.Height = 24;
            this.dgDivisiones.Size = new System.Drawing.Size(617, 311);
            this.dgDivisiones.TabIndex = 21;
            this.dgDivisiones.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDivisiones_CellEnter);
            // 
            // dgCategorias
            // 
            this.dgCategorias.AllowUserToAddRows = false;
            this.dgCategorias.AllowUserToDeleteRows = false;
            this.dgCategorias.AllowUserToResizeColumns = false;
            this.dgCategorias.AllowUserToResizeRows = false;
            this.dgCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgCategorias.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgCategorias.Location = new System.Drawing.Point(496, 78);
            this.dgCategorias.MultiSelect = false;
            this.dgCategorias.Name = "dgCategorias";
            this.dgCategorias.ReadOnly = true;
            this.dgCategorias.RowHeadersVisible = false;
            this.dgCategorias.RowTemplate.Height = 24;
            this.dgCategorias.Size = new System.Drawing.Size(381, 185);
            this.dgCategorias.TabIndex = 22;
            this.dgCategorias.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategorias_CellEnter);
            // 
            // groupBoxDivisiones
            // 
            this.groupBoxDivisiones.Controls.Add(this.comboBoxCategorias);
            this.groupBoxDivisiones.Controls.Add(this.textBoxNombreDiv);
            this.groupBoxDivisiones.Controls.Add(this.labelCategoria);
            this.groupBoxDivisiones.Controls.Add(this.labelNombreDiv);
            this.groupBoxDivisiones.Enabled = false;
            this.groupBoxDivisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDivisiones.Location = new System.Drawing.Point(14, 377);
            this.groupBoxDivisiones.Name = "groupBoxDivisiones";
            this.groupBoxDivisiones.Size = new System.Drawing.Size(476, 224);
            this.groupBoxDivisiones.TabIndex = 23;
            this.groupBoxDivisiones.TabStop = false;
            this.groupBoxDivisiones.Text = "División";
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(114, 130);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(343, 21);
            this.comboBoxCategorias.TabIndex = 34;
            // 
            // textBoxNombreDiv
            // 
            this.textBoxNombreDiv.Location = new System.Drawing.Point(114, 56);
            this.textBoxNombreDiv.Name = "textBoxNombreDiv";
            this.textBoxNombreDiv.Size = new System.Drawing.Size(343, 20);
            this.textBoxNombreDiv.TabIndex = 8;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(4, 130);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(67, 13);
            this.labelCategoria.TabIndex = 33;
            this.labelCategoria.Text = "Categoría:";
            // 
            // labelNombreDiv
            // 
            this.labelNombreDiv.AutoSize = true;
            this.labelNombreDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDiv.Location = new System.Drawing.Point(19, 63);
            this.labelNombreDiv.Name = "labelNombreDiv";
            this.labelNombreDiv.Size = new System.Drawing.Size(54, 13);
            this.labelNombreDiv.TabIndex = 1;
            this.labelNombreDiv.Text = "Nombre:";
            // 
            // buttonCancelarDiv
            // 
            this.buttonCancelarDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelarDiv.Enabled = false;
            this.buttonCancelarDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarDiv.Location = new System.Drawing.Point(230, 607);
            this.buttonCancelarDiv.Name = "buttonCancelarDiv";
            this.buttonCancelarDiv.Size = new System.Drawing.Size(79, 30);
            this.buttonCancelarDiv.TabIndex = 27;
            this.buttonCancelarDiv.Text = "Cancelar";
            this.buttonCancelarDiv.UseVisualStyleBackColor = true;
            this.buttonCancelarDiv.Click += new System.EventHandler(this.buttonCancelarDiv_Click);
            // 
            // buttonEliminarDiv
            // 
            this.buttonEliminarDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarDiv.Location = new System.Drawing.Point(315, 607);
            this.buttonEliminarDiv.Name = "buttonEliminarDiv";
            this.buttonEliminarDiv.Size = new System.Drawing.Size(110, 30);
            this.buttonEliminarDiv.TabIndex = 26;
            this.buttonEliminarDiv.Text = "Eliminar";
            this.buttonEliminarDiv.UseVisualStyleBackColor = true;
            this.buttonEliminarDiv.Click += new System.EventHandler(this.buttonEliminarDiv_Click);
            // 
            // buttonEditarDiv
            // 
            this.buttonEditarDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditarDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarDiv.Location = new System.Drawing.Point(136, 607);
            this.buttonEditarDiv.Name = "buttonEditarDiv";
            this.buttonEditarDiv.Size = new System.Drawing.Size(88, 30);
            this.buttonEditarDiv.TabIndex = 25;
            this.buttonEditarDiv.Text = "Editar";
            this.buttonEditarDiv.UseVisualStyleBackColor = true;
            this.buttonEditarDiv.Click += new System.EventHandler(this.buttonEditarDiv_Click);
            // 
            // buttonAgregarDiv
            // 
            this.buttonAgregarDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregarDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarDiv.Location = new System.Drawing.Point(14, 607);
            this.buttonAgregarDiv.Name = "buttonAgregarDiv";
            this.buttonAgregarDiv.Size = new System.Drawing.Size(116, 30);
            this.buttonAgregarDiv.TabIndex = 24;
            this.buttonAgregarDiv.Text = "Agregar";
            this.buttonAgregarDiv.UseVisualStyleBackColor = true;
            this.buttonAgregarDiv.Click += new System.EventHandler(this.buttonAgregarDiv_Click);
            // 
            // labelBuscarDiv
            // 
            this.labelBuscarDiv.AutoSize = true;
            this.labelBuscarDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarDiv.Location = new System.Drawing.Point(493, 304);
            this.labelBuscarDiv.Name = "labelBuscarDiv";
            this.labelBuscarDiv.Size = new System.Drawing.Size(117, 13);
            this.labelBuscarDiv.TabIndex = 28;
            this.labelBuscarDiv.Text = "Buscar por nombre:";
            // 
            // textBoxBuscarDivision
            // 
            this.textBoxBuscarDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarDivision.Location = new System.Drawing.Point(616, 297);
            this.textBoxBuscarDivision.Name = "textBoxBuscarDivision";
            this.textBoxBuscarDivision.Size = new System.Drawing.Size(497, 20);
            this.textBoxBuscarDivision.TabIndex = 29;
            this.textBoxBuscarDivision.TextChanged += new System.EventHandler(this.textBoxBuscarDivision_TextChanged);
            // 
            // labelBuscarNombreCat
            // 
            this.labelBuscarNombreCat.AutoSize = true;
            this.labelBuscarNombreCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarNombreCat.Location = new System.Drawing.Point(493, 58);
            this.labelBuscarNombreCat.Name = "labelBuscarNombreCat";
            this.labelBuscarNombreCat.Size = new System.Drawing.Size(117, 13);
            this.labelBuscarNombreCat.TabIndex = 30;
            this.labelBuscarNombreCat.Text = "Buscar por nombre:";
            // 
            // textBoxBuscarCategoria
            // 
            this.textBoxBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarCategoria.Location = new System.Drawing.Point(616, 51);
            this.textBoxBuscarCategoria.Name = "textBoxBuscarCategoria";
            this.textBoxBuscarCategoria.Size = new System.Drawing.Size(261, 20);
            this.textBoxBuscarCategoria.TabIndex = 31;
            this.textBoxBuscarCategoria.TextChanged += new System.EventHandler(this.textBoxBuscarCategoria_TextChanged);
            // 
            // buttonCancelarCat
            // 
            this.buttonCancelarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelarCat.Enabled = false;
            this.buttonCancelarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCat.Location = new System.Drawing.Point(245, 226);
            this.buttonCancelarCat.Name = "buttonCancelarCat";
            this.buttonCancelarCat.Size = new System.Drawing.Size(110, 30);
            this.buttonCancelarCat.TabIndex = 32;
            this.buttonCancelarCat.Text = "Cancelar";
            this.buttonCancelarCat.UseVisualStyleBackColor = true;
            this.buttonCancelarCat.Click += new System.EventHandler(this.buttonCancelarCat_Click);
            // 
            // buttonEliminarCat
            // 
            this.buttonEliminarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarCat.Location = new System.Drawing.Point(361, 226);
            this.buttonEliminarCat.Name = "buttonEliminarCat";
            this.buttonEliminarCat.Size = new System.Drawing.Size(110, 30);
            this.buttonEliminarCat.TabIndex = 31;
            this.buttonEliminarCat.Text = "Eliminar";
            this.buttonEliminarCat.UseVisualStyleBackColor = true;
            this.buttonEliminarCat.Click += new System.EventHandler(this.buttonEliminarCat_Click);
            // 
            // buttonEditarCat
            // 
            this.buttonEditarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarCat.Location = new System.Drawing.Point(129, 226);
            this.buttonEditarCat.Name = "buttonEditarCat";
            this.buttonEditarCat.Size = new System.Drawing.Size(110, 30);
            this.buttonEditarCat.TabIndex = 30;
            this.buttonEditarCat.Text = "Editar";
            this.buttonEditarCat.UseVisualStyleBackColor = true;
            this.buttonEditarCat.Click += new System.EventHandler(this.buttonEditarCat_Click);
            // 
            // buttonAgregarCat
            // 
            this.buttonAgregarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarCat.Location = new System.Drawing.Point(13, 226);
            this.buttonAgregarCat.Name = "buttonAgregarCat";
            this.buttonAgregarCat.Size = new System.Drawing.Size(110, 30);
            this.buttonAgregarCat.TabIndex = 29;
            this.buttonAgregarCat.Text = "Agregar";
            this.buttonAgregarCat.UseVisualStyleBackColor = true;
            this.buttonAgregarCat.Click += new System.EventHandler(this.buttonAgregarCat_Click);
            // 
            // groupBoxCategorias
            // 
            this.groupBoxCategorias.Controls.Add(this.rbFemCat);
            this.groupBoxCategorias.Controls.Add(this.rbVarCat);
            this.groupBoxCategorias.Controls.Add(this.textBoxNombreCat);
            this.groupBoxCategorias.Controls.Add(this.labelRamaCat);
            this.groupBoxCategorias.Controls.Add(this.labelNombreCat);
            this.groupBoxCategorias.Enabled = false;
            this.groupBoxCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCategorias.Location = new System.Drawing.Point(13, 118);
            this.groupBoxCategorias.Name = "groupBoxCategorias";
            this.groupBoxCategorias.Size = new System.Drawing.Size(477, 102);
            this.groupBoxCategorias.TabIndex = 28;
            this.groupBoxCategorias.TabStop = false;
            this.groupBoxCategorias.Text = "Categoría";
            // 
            // rbFemCat
            // 
            this.rbFemCat.AutoSize = true;
            this.rbFemCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFemCat.Location = new System.Drawing.Point(230, 59);
            this.rbFemCat.Name = "rbFemCat";
            this.rbFemCat.Size = new System.Drawing.Size(68, 17);
            this.rbFemCat.TabIndex = 11;
            this.rbFemCat.Text = "Femenil";
            this.rbFemCat.UseVisualStyleBackColor = true;
            // 
            // rbVarCat
            // 
            this.rbVarCat.AutoSize = true;
            this.rbVarCat.Checked = true;
            this.rbVarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbVarCat.Location = new System.Drawing.Point(120, 59);
            this.rbVarCat.Name = "rbVarCat";
            this.rbVarCat.Size = new System.Drawing.Size(64, 17);
            this.rbVarCat.TabIndex = 10;
            this.rbVarCat.TabStop = true;
            this.rbVarCat.Text = "Varonil";
            this.rbVarCat.UseVisualStyleBackColor = true;
            // 
            // textBoxNombreCat
            // 
            this.textBoxNombreCat.Location = new System.Drawing.Point(114, 26);
            this.textBoxNombreCat.Name = "textBoxNombreCat";
            this.textBoxNombreCat.Size = new System.Drawing.Size(344, 20);
            this.textBoxNombreCat.TabIndex = 8;
            // 
            // labelRamaCat
            // 
            this.labelRamaCat.AutoSize = true;
            this.labelRamaCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRamaCat.Location = new System.Drawing.Point(45, 61);
            this.labelRamaCat.Name = "labelRamaCat";
            this.labelRamaCat.Size = new System.Drawing.Size(54, 17);
            this.labelRamaCat.TabIndex = 2;
            this.labelRamaCat.Text = "Rama:";
            // 
            // labelNombreCat
            // 
            this.labelNombreCat.AutoSize = true;
            this.labelNombreCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCat.Location = new System.Drawing.Point(19, 33);
            this.labelNombreCat.Name = "labelNombreCat";
            this.labelNombreCat.Size = new System.Drawing.Size(69, 17);
            this.labelNombreCat.TabIndex = 1;
            this.labelNombreCat.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Filtrar por categoría:";
            // 
            // comboBoxFiltCat
            // 
            this.comboBoxFiltCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFiltCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltCat.FormattingEnabled = true;
            this.comboBoxFiltCat.Location = new System.Drawing.Point(154, 328);
            this.comboBoxFiltCat.Name = "comboBoxFiltCat";
            this.comboBoxFiltCat.Size = new System.Drawing.Size(317, 21);
            this.comboBoxFiltCat.TabIndex = 35;
            this.comboBoxFiltCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltCat_SelectedIndexChanged);
            this.comboBoxFiltCat.Click += new System.EventHandler(this.comboBoxFiltCat_Click);
            // 
            // comboBoxFiltRama
            // 
            this.comboBoxFiltRama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFiltRama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltRama.FormattingEnabled = true;
            this.comboBoxFiltRama.Items.AddRange(new object[] {
            "Varonil",
            "Femenil"});
            this.comboBoxFiltRama.Location = new System.Drawing.Point(127, 78);
            this.comboBoxFiltRama.Name = "comboBoxFiltRama";
            this.comboBoxFiltRama.Size = new System.Drawing.Size(344, 21);
            this.comboBoxFiltRama.TabIndex = 37;
            this.comboBoxFiltRama.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltRama_SelectedIndexChanged);
            this.comboBoxFiltRama.Click += new System.EventHandler(this.comboBoxFiltRama_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(3, 81);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(101, 13);
            this.label.TabIndex = 36;
            this.label.Text = "Filtrar por Rama:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BoxManager.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(882, 118);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(231, 93);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 38;
            this.pictureBoxLogo.TabStop = false;
            // 
            // DivisionesCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 648);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.comboBoxFiltRama);
            this.Controls.Add(this.label);
            this.Controls.Add(this.comboBoxFiltCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelarCat);
            this.Controls.Add(this.labelBuscarNombreCat);
            this.Controls.Add(this.buttonEliminarCat);
            this.Controls.Add(this.textBoxBuscarCategoria);
            this.Controls.Add(this.buttonEditarCat);
            this.Controls.Add(this.labelBuscarDiv);
            this.Controls.Add(this.buttonAgregarCat);
            this.Controls.Add(this.textBoxBuscarDivision);
            this.Controls.Add(this.groupBoxCategorias);
            this.Controls.Add(this.buttonCancelarDiv);
            this.Controls.Add(this.buttonEliminarDiv);
            this.Controls.Add(this.buttonEditarDiv);
            this.Controls.Add(this.buttonAgregarDiv);
            this.Controls.Add(this.groupBoxDivisiones);
            this.Controls.Add(this.dgCategorias);
            this.Controls.Add(this.dgDivisiones);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelCategorias);
            this.Controls.Add(this.labelDivisiones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DivisionesCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DivsionesCategorias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DivsionesCategorias_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgDivisiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).EndInit();
            this.groupBoxDivisiones.ResumeLayout(false);
            this.groupBoxDivisiones.PerformLayout();
            this.groupBoxCategorias.ResumeLayout(false);
            this.groupBoxCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDivisiones;
        private System.Windows.Forms.Label labelCategorias;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.DataGridView dgDivisiones;
        private System.Windows.Forms.DataGridView dgCategorias;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxDivisiones;
        private System.Windows.Forms.TextBox textBoxNombreDiv;
        private System.Windows.Forms.Label labelNombreDiv;
        private System.Windows.Forms.Button buttonCancelarDiv;
        private System.Windows.Forms.Button buttonEliminarDiv;
        private System.Windows.Forms.Button buttonEditarDiv;
        private System.Windows.Forms.Button buttonAgregarDiv;
        private System.Windows.Forms.Label labelBuscarDiv;
        private System.Windows.Forms.TextBox textBoxBuscarDivision;
        private System.Windows.Forms.Label labelBuscarNombreCat;
        private System.Windows.Forms.TextBox textBoxBuscarCategoria;
        private System.Windows.Forms.Button buttonCancelarCat;
        private System.Windows.Forms.Button buttonEliminarCat;
        private System.Windows.Forms.Button buttonEditarCat;
        private System.Windows.Forms.Button buttonAgregarCat;
        private System.Windows.Forms.GroupBox groupBoxCategorias;
        private System.Windows.Forms.RadioButton rbFemCat;
        private System.Windows.Forms.RadioButton rbVarCat;
        private System.Windows.Forms.TextBox textBoxNombreCat;
        private System.Windows.Forms.Label labelRamaCat;
        private System.Windows.Forms.Label labelNombreCat;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFiltCat;
        private System.Windows.Forms.ComboBox comboBoxFiltRama;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}