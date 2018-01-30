namespace BoxManager.Interfaces
{
    partial class AdmisnitrarTorneo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmisnitrarTorneo));
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelCategorias = new System.Windows.Forms.Label();
            this.dgPeleas = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonGanador = new System.Windows.Forms.Button();
            this.labelNombreCat = new System.Windows.Forms.Label();
            this.buttonGuardarCambios = new System.Windows.Forms.Button();
            this.comboBoxTorneos = new System.Windows.Forms.ComboBox();
            this.buttonEliminarTorneo = new System.Windows.Forms.Button();
            this.buttonEtapa = new System.Windows.Forms.Button();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.labelMunicipio = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescMunicipio = new System.Windows.Forms.Label();
            this.labelDescNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelParticipantes = new System.Windows.Forms.Label();
            this.labelDescParticipantes = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelDescCategoria = new System.Windows.Forms.Label();
            this.labelCreandoRandom = new System.Windows.Forms.Label();
            this.progressBarPeleas = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeleas)).BeginInit();
            this.groupBoxDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(11, 11);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(82, 41);
            this.buttonMenu.TabIndex = 8;
            this.buttonMenu.Text = "Menú";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelCategorias
            // 
            this.labelCategorias.AutoSize = true;
            this.labelCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorias.Location = new System.Drawing.Point(123, 11);
            this.labelCategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategorias.Name = "labelCategorias";
            this.labelCategorias.Size = new System.Drawing.Size(487, 63);
            this.labelCategorias.TabIndex = 25;
            this.labelCategorias.Text = "Administrar Torneo";
            // 
            // dgPeleas
            // 
            this.dgPeleas.AllowUserToAddRows = false;
            this.dgPeleas.AllowUserToDeleteRows = false;
            this.dgPeleas.AllowUserToResizeColumns = false;
            this.dgPeleas.AllowUserToResizeRows = false;
            this.dgPeleas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgPeleas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgPeleas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPeleas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeleas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPeleas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgPeleas.Location = new System.Drawing.Point(11, 147);
            this.dgPeleas.MultiSelect = false;
            this.dgPeleas.Name = "dgPeleas";
            this.dgPeleas.ReadOnly = true;
            this.dgPeleas.RowHeadersVisible = false;
            this.dgPeleas.RowTemplate.Height = 24;
            this.dgPeleas.Size = new System.Drawing.Size(560, 303);
            this.dgPeleas.TabIndex = 28;
            this.dgPeleas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPeleas_CellEnter);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.Enabled = false;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(577, 183);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(110, 30);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImprimir.Enabled = false;
            this.buttonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimir.Location = new System.Drawing.Point(577, 219);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(110, 30);
            this.buttonImprimir.TabIndex = 6;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // buttonGanador
            // 
            this.buttonGanador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGanador.Enabled = false;
            this.buttonGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGanador.Location = new System.Drawing.Point(577, 147);
            this.buttonGanador.Name = "buttonGanador";
            this.buttonGanador.Size = new System.Drawing.Size(110, 30);
            this.buttonGanador.TabIndex = 2;
            this.buttonGanador.Text = "Ganador";
            this.buttonGanador.UseVisualStyleBackColor = true;
            this.buttonGanador.Click += new System.EventHandler(this.buttonGanador_Click);
            // 
            // labelNombreCat
            // 
            this.labelNombreCat.AutoSize = true;
            this.labelNombreCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCat.Location = new System.Drawing.Point(12, 127);
            this.labelNombreCat.Name = "labelNombreCat";
            this.labelNombreCat.Size = new System.Drawing.Size(155, 17);
            this.labelNombreCat.TabIndex = 36;
            this.labelNombreCat.Text = "Seleccionar Torneo:";
            // 
            // buttonGuardarCambios
            // 
            this.buttonGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarCambios.Location = new System.Drawing.Point(577, 403);
            this.buttonGuardarCambios.Name = "buttonGuardarCambios";
            this.buttonGuardarCambios.Size = new System.Drawing.Size(110, 47);
            this.buttonGuardarCambios.TabIndex = 4;
            this.buttonGuardarCambios.Text = "Guardar Cambios";
            this.buttonGuardarCambios.UseVisualStyleBackColor = true;
            this.buttonGuardarCambios.Click += new System.EventHandler(this.buttonGuardarCambios_Click);
            // 
            // comboBoxTorneos
            // 
            this.comboBoxTorneos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTorneos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTorneos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTorneos.FormattingEnabled = true;
            this.comboBoxTorneos.Location = new System.Drawing.Point(173, 123);
            this.comboBoxTorneos.Name = "comboBoxTorneos";
            this.comboBoxTorneos.Size = new System.Drawing.Size(288, 21);
            this.comboBoxTorneos.TabIndex = 1;
            this.comboBoxTorneos.SelectedIndexChanged += new System.EventHandler(this.comboBoxTorneos_SelectedIndexChanged);
            this.comboBoxTorneos.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTorneos_SelectionChangeCommitted);
            // 
            // buttonEliminarTorneo
            // 
            this.buttonEliminarTorneo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarTorneo.Location = new System.Drawing.Point(864, 27);
            this.buttonEliminarTorneo.Name = "buttonEliminarTorneo";
            this.buttonEliminarTorneo.Size = new System.Drawing.Size(110, 47);
            this.buttonEliminarTorneo.TabIndex = 7;
            this.buttonEliminarTorneo.Text = "Eliminar Torneo";
            this.buttonEliminarTorneo.UseVisualStyleBackColor = true;
            this.buttonEliminarTorneo.Click += new System.EventHandler(this.buttonEliminarTorneo_Click);
            // 
            // buttonEtapa
            // 
            this.buttonEtapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEtapa.Enabled = false;
            this.buttonEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEtapa.Location = new System.Drawing.Point(577, 328);
            this.buttonEtapa.Name = "buttonEtapa";
            this.buttonEtapa.Size = new System.Drawing.Size(110, 45);
            this.buttonEtapa.TabIndex = 5;
            this.buttonEtapa.Text = "Siguiente Etapa";
            this.buttonEtapa.UseVisualStyleBackColor = true;
            this.buttonEtapa.Click += new System.EventHandler(this.buttonEtapa_Click);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.labelMunicipio);
            this.groupBoxDatos.Controls.Add(this.labelNombre);
            this.groupBoxDatos.Controls.Add(this.labelDescMunicipio);
            this.groupBoxDatos.Controls.Add(this.labelDescNombre);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatos.Location = new System.Drawing.Point(692, 181);
            this.groupBoxDatos.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDatos.Size = new System.Drawing.Size(293, 88);
            this.groupBoxDatos.TabIndex = 42;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos del boxeador";
            // 
            // labelMunicipio
            // 
            this.labelMunicipio.AutoSize = true;
            this.labelMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMunicipio.Location = new System.Drawing.Point(73, 57);
            this.labelMunicipio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMunicipio.Name = "labelMunicipio";
            this.labelMunicipio.Size = new System.Drawing.Size(114, 13);
            this.labelMunicipio.TabIndex = 8;
            this.labelMunicipio.Text = "MunicipioBoxeador";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(73, 26);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(103, 13);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "NombreBoxeador";
            // 
            // labelDescMunicipio
            // 
            this.labelDescMunicipio.AutoSize = true;
            this.labelDescMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescMunicipio.Location = new System.Drawing.Point(4, 57);
            this.labelDescMunicipio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescMunicipio.Name = "labelDescMunicipio";
            this.labelDescMunicipio.Size = new System.Drawing.Size(65, 13);
            this.labelDescMunicipio.TabIndex = 6;
            this.labelDescMunicipio.Text = "Municipio:";
            // 
            // labelDescNombre
            // 
            this.labelDescNombre.AutoSize = true;
            this.labelDescNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescNombre.Location = new System.Drawing.Point(15, 26);
            this.labelDescNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescNombre.Name = "labelDescNombre";
            this.labelDescNombre.Size = new System.Drawing.Size(54, 13);
            this.labelDescNombre.TabIndex = 1;
            this.labelDescNombre.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelParticipantes);
            this.groupBox1.Controls.Add(this.labelDescParticipantes);
            this.groupBox1.Controls.Add(this.labelCategoria);
            this.groupBox1.Controls.Add(this.labelDescCategoria);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(692, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(293, 85);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Torneo";
            // 
            // labelParticipantes
            // 
            this.labelParticipantes.AutoSize = true;
            this.labelParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParticipantes.Location = new System.Drawing.Point(93, 55);
            this.labelParticipantes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelParticipantes.Name = "labelParticipantes";
            this.labelParticipantes.Size = new System.Drawing.Size(0, 13);
            this.labelParticipantes.TabIndex = 10;
            // 
            // labelDescParticipantes
            // 
            this.labelDescParticipantes.AutoSize = true;
            this.labelDescParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescParticipantes.Location = new System.Drawing.Point(4, 55);
            this.labelDescParticipantes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescParticipantes.Name = "labelDescParticipantes";
            this.labelDescParticipantes.Size = new System.Drawing.Size(85, 13);
            this.labelDescParticipantes.TabIndex = 9;
            this.labelDescParticipantes.Text = "Participantes:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(89, 26);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(0, 13);
            this.labelCategoria.TabIndex = 7;
            // 
            // labelDescCategoria
            // 
            this.labelDescCategoria.AutoSize = true;
            this.labelDescCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescCategoria.Location = new System.Drawing.Point(22, 26);
            this.labelDescCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescCategoria.Name = "labelDescCategoria";
            this.labelDescCategoria.Size = new System.Drawing.Size(67, 13);
            this.labelDescCategoria.TabIndex = 1;
            this.labelDescCategoria.Text = "Categoría:";
            // 
            // labelCreandoRandom
            // 
            this.labelCreandoRandom.AutoSize = true;
            this.labelCreandoRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreandoRandom.Location = new System.Drawing.Point(713, 272);
            this.labelCreandoRandom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreandoRandom.Name = "labelCreandoRandom";
            this.labelCreandoRandom.Size = new System.Drawing.Size(255, 25);
            this.labelCreandoRandom.TabIndex = 48;
            this.labelCreandoRandom.Text = "Creando peleas aleatorias...";
            this.labelCreandoRandom.Visible = false;
            // 
            // progressBarPeleas
            // 
            this.progressBarPeleas.Location = new System.Drawing.Point(727, 300);
            this.progressBarPeleas.Name = "progressBarPeleas";
            this.progressBarPeleas.Size = new System.Drawing.Size(221, 23);
            this.progressBarPeleas.Step = 3;
            this.progressBarPeleas.TabIndex = 47;
            this.progressBarPeleas.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BoxManager.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(692, 328);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // AdmisnitrarTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 467);
            this.Controls.Add(this.labelCreandoRandom);
            this.Controls.Add(this.progressBarPeleas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEtapa);
            this.Controls.Add(this.buttonEliminarTorneo);
            this.Controls.Add(this.comboBoxTorneos);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.buttonGuardarCambios);
            this.Controls.Add(this.labelNombreCat);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.buttonGanador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelCategorias);
            this.Controls.Add(this.dgPeleas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdmisnitrarTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admisnitrar Torneo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdmisnitrarTorneo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgPeleas)).EndInit();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label labelCategorias;
        private System.Windows.Forms.DataGridView dgPeleas;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonGanador;
        private System.Windows.Forms.Label labelNombreCat;
        private System.Windows.Forms.Button buttonGuardarCambios;
        private System.Windows.Forms.ComboBox comboBoxTorneos;
        private System.Windows.Forms.Button buttonEliminarTorneo;
        private System.Windows.Forms.Button buttonEtapa;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label labelMunicipio;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescMunicipio;
        private System.Windows.Forms.Label labelDescNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelDescCategoria;
        private System.Windows.Forms.Label labelParticipantes;
        private System.Windows.Forms.Label labelDescParticipantes;
        private System.Windows.Forms.Label labelCreandoRandom;
        private System.Windows.Forms.ProgressBar progressBarPeleas;
        private System.Windows.Forms.Timer timer1;
    }
}