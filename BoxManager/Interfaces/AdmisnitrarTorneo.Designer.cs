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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeleas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BoxManager.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(221, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(11, 11);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(82, 41);
            this.buttonMenu.TabIndex = 26;
            this.buttonMenu.Text = "Menú";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelCategorias
            // 
            this.labelCategorias.AutoSize = true;
            this.labelCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorias.Location = new System.Drawing.Point(166, 13);
            this.labelCategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategorias.Name = "labelCategorias";
            this.labelCategorias.Size = new System.Drawing.Size(313, 39);
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
            this.dgPeleas.Location = new System.Drawing.Point(11, 147);
            this.dgPeleas.MultiSelect = false;
            this.dgPeleas.Name = "dgPeleas";
            this.dgPeleas.ReadOnly = true;
            this.dgPeleas.RowHeadersVisible = false;
            this.dgPeleas.RowTemplate.Height = 24;
            this.dgPeleas.Size = new System.Drawing.Size(450, 375);
            this.dgPeleas.TabIndex = 28;
            this.dgPeleas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPeleas_CellEnter);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.Enabled = false;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(467, 183);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(110, 30);
            this.buttonCancelar.TabIndex = 35;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimir.Location = new System.Drawing.Point(467, 219);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(110, 30);
            this.buttonImprimir.TabIndex = 34;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            // 
            // buttonGanador
            // 
            this.buttonGanador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGanador.Enabled = false;
            this.buttonGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGanador.Location = new System.Drawing.Point(467, 147);
            this.buttonGanador.Name = "buttonGanador";
            this.buttonGanador.Size = new System.Drawing.Size(110, 30);
            this.buttonGanador.TabIndex = 33;
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
            this.buttonGuardarCambios.Location = new System.Drawing.Point(467, 475);
            this.buttonGuardarCambios.Name = "buttonGuardarCambios";
            this.buttonGuardarCambios.Size = new System.Drawing.Size(110, 47);
            this.buttonGuardarCambios.TabIndex = 38;
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
            this.comboBoxTorneos.TabIndex = 39;
            this.comboBoxTorneos.SelectedIndexChanged += new System.EventHandler(this.comboBoxTorneos_SelectedIndexChanged);
            this.comboBoxTorneos.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTorneos_SelectionChangeCommitted);
            // 
            // buttonEliminarTorneo
            // 
            this.buttonEliminarTorneo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarTorneo.Location = new System.Drawing.Point(467, 55);
            this.buttonEliminarTorneo.Name = "buttonEliminarTorneo";
            this.buttonEliminarTorneo.Size = new System.Drawing.Size(110, 47);
            this.buttonEliminarTorneo.TabIndex = 40;
            this.buttonEliminarTorneo.Text = "Eliminar Torneo";
            this.buttonEliminarTorneo.UseVisualStyleBackColor = true;
            this.buttonEliminarTorneo.Click += new System.EventHandler(this.buttonEliminarTorneo_Click);
            // 
            // AdmisnitrarTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 534);
            this.Controls.Add(this.buttonEliminarTorneo);
            this.Controls.Add(this.comboBoxTorneos);
            this.Controls.Add(this.buttonGuardarCambios);
            this.Controls.Add(this.labelNombreCat);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.buttonGanador);
            this.Controls.Add(this.dgPeleas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdmisnitrarTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admisnitrar Torneo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdmisnitrarTorneo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeleas)).EndInit();
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
    }
}