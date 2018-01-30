namespace BoxManager
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonReporteBoxeadores = new System.Windows.Forms.Button();
            this.buttonBoxeadores = new System.Windows.Forms.Button();
            this.buttonCatDiv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAgregarCateDiv = new System.Windows.Forms.Button();
            this.buttonAgregarBoxeador = new System.Windows.Forms.Button();
            this.labelCantAcciones = new System.Windows.Forms.Label();
            this.labelCantDivisiones = new System.Windows.Forms.Label();
            this.labelCantCategorias = new System.Windows.Forms.Label();
            this.labelCantBoxeadores = new System.Windows.Forms.Label();
            this.labelBuscarNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonHistorial = new System.Windows.Forms.Button();
            this.buttonCrearTorneo = new System.Windows.Forms.Button();
            this.buttonAdministrarTorneo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReporteBoxeadores
            // 
            this.buttonReporteBoxeadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReporteBoxeadores.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonReporteBoxeadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonReporteBoxeadores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonReporteBoxeadores.Location = new System.Drawing.Point(412, 151);
            this.buttonReporteBoxeadores.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonReporteBoxeadores.Name = "buttonReporteBoxeadores";
            this.buttonReporteBoxeadores.Size = new System.Drawing.Size(149, 62);
            this.buttonReporteBoxeadores.TabIndex = 4;
            this.buttonReporteBoxeadores.Text = "Reporte Boxeadores";
            this.buttonReporteBoxeadores.UseVisualStyleBackColor = true;
            this.buttonReporteBoxeadores.Click += new System.EventHandler(this.buttonCrearTorneo_Click);
            // 
            // buttonBoxeadores
            // 
            this.buttonBoxeadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBoxeadores.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonBoxeadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonBoxeadores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBoxeadores.Location = new System.Drawing.Point(9, 151);
            this.buttonBoxeadores.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonBoxeadores.Name = "buttonBoxeadores";
            this.buttonBoxeadores.Size = new System.Drawing.Size(149, 62);
            this.buttonBoxeadores.TabIndex = 1;
            this.buttonBoxeadores.Text = "Boxeadores";
            this.buttonBoxeadores.UseVisualStyleBackColor = true;
            this.buttonBoxeadores.Click += new System.EventHandler(this.buttonBoxeadores_Click);
            // 
            // buttonCatDiv
            // 
            this.buttonCatDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCatDiv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCatDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonCatDiv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCatDiv.Location = new System.Drawing.Point(9, 233);
            this.buttonCatDiv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCatDiv.Name = "buttonCatDiv";
            this.buttonCatDiv.Size = new System.Drawing.Size(149, 62);
            this.buttonCatDiv.TabIndex = 2;
            this.buttonCatDiv.Text = "Divisiones y Categorías";
            this.buttonCatDiv.UseVisualStyleBackColor = true;
            this.buttonCatDiv.Click += new System.EventHandler(this.buttonCatDiv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAgregarCateDiv);
            this.groupBox1.Controls.Add(this.buttonAgregarBoxeador);
            this.groupBox1.Controls.Add(this.labelCantAcciones);
            this.groupBox1.Controls.Add(this.labelCantDivisiones);
            this.groupBox1.Controls.Add(this.labelCantCategorias);
            this.groupBox1.Controls.Add(this.labelCantBoxeadores);
            this.groupBox1.Controls.Add(this.labelBuscarNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(190, 230);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(189, 152);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonAgregarCateDiv
            // 
            this.buttonAgregarCateDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregarCateDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarCateDiv.Location = new System.Drawing.Point(158, 65);
            this.buttonAgregarCateDiv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAgregarCateDiv.Name = "buttonAgregarCateDiv";
            this.buttonAgregarCateDiv.Size = new System.Drawing.Size(26, 46);
            this.buttonAgregarCateDiv.TabIndex = 8;
            this.buttonAgregarCateDiv.Text = "+";
            this.buttonAgregarCateDiv.UseVisualStyleBackColor = true;
            this.buttonAgregarCateDiv.Click += new System.EventHandler(this.buttonAgregarCateDiv_Click);
            // 
            // buttonAgregarBoxeador
            // 
            this.buttonAgregarBoxeador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregarBoxeador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarBoxeador.Location = new System.Drawing.Point(158, 35);
            this.buttonAgregarBoxeador.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAgregarBoxeador.Name = "buttonAgregarBoxeador";
            this.buttonAgregarBoxeador.Size = new System.Drawing.Size(26, 23);
            this.buttonAgregarBoxeador.TabIndex = 7;
            this.buttonAgregarBoxeador.Text = "+";
            this.buttonAgregarBoxeador.UseVisualStyleBackColor = true;
            this.buttonAgregarBoxeador.Click += new System.EventHandler(this.buttonAgregarBoxeador_Click);
            // 
            // labelCantAcciones
            // 
            this.labelCantAcciones.AutoSize = true;
            this.labelCantAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantAcciones.Location = new System.Drawing.Point(115, 126);
            this.labelCantAcciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantAcciones.Name = "labelCantAcciones";
            this.labelCantAcciones.Size = new System.Drawing.Size(17, 17);
            this.labelCantAcciones.TabIndex = 37;
            this.labelCantAcciones.Text = "0";
            this.labelCantAcciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCantDivisiones
            // 
            this.labelCantDivisiones.AutoSize = true;
            this.labelCantDivisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantDivisiones.Location = new System.Drawing.Point(115, 95);
            this.labelCantDivisiones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantDivisiones.Name = "labelCantDivisiones";
            this.labelCantDivisiones.Size = new System.Drawing.Size(17, 17);
            this.labelCantDivisiones.TabIndex = 36;
            this.labelCantDivisiones.Text = "0";
            this.labelCantDivisiones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCantCategorias
            // 
            this.labelCantCategorias.AutoSize = true;
            this.labelCantCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantCategorias.Location = new System.Drawing.Point(115, 68);
            this.labelCantCategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantCategorias.Name = "labelCantCategorias";
            this.labelCantCategorias.Size = new System.Drawing.Size(17, 17);
            this.labelCantCategorias.TabIndex = 35;
            this.labelCantCategorias.Text = "0";
            this.labelCantCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCantBoxeadores
            // 
            this.labelCantBoxeadores.AutoSize = true;
            this.labelCantBoxeadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantBoxeadores.Location = new System.Drawing.Point(115, 42);
            this.labelCantBoxeadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantBoxeadores.Name = "labelCantBoxeadores";
            this.labelCantBoxeadores.Size = new System.Drawing.Size(17, 17);
            this.labelCantBoxeadores.TabIndex = 34;
            this.labelCantBoxeadores.Text = "0";
            this.labelCantBoxeadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBuscarNombre
            // 
            this.labelBuscarNombre.AutoSize = true;
            this.labelBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarNombre.Location = new System.Drawing.Point(5, 42);
            this.labelBuscarNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuscarNombre.Name = "labelBuscarNombre";
            this.labelBuscarNombre.Size = new System.Drawing.Size(98, 17);
            this.labelBuscarNombre.TabIndex = 25;
            this.labelBuscarNombre.Text = "Boxeadores:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Categorías:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Divisiones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Acciones:";
            // 
            // buttonHistorial
            // 
            this.buttonHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHistorial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonHistorial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonHistorial.Location = new System.Drawing.Point(9, 320);
            this.buttonHistorial.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonHistorial.Name = "buttonHistorial";
            this.buttonHistorial.Size = new System.Drawing.Size(149, 62);
            this.buttonHistorial.TabIndex = 3;
            this.buttonHistorial.Text = "Historial de Acciones";
            this.buttonHistorial.UseVisualStyleBackColor = true;
            this.buttonHistorial.Click += new System.EventHandler(this.buttonHistorial_Click);
            // 
            // buttonCrearTorneo
            // 
            this.buttonCrearTorneo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearTorneo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCrearTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonCrearTorneo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCrearTorneo.Location = new System.Drawing.Point(412, 233);
            this.buttonCrearTorneo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCrearTorneo.Name = "buttonCrearTorneo";
            this.buttonCrearTorneo.Size = new System.Drawing.Size(149, 62);
            this.buttonCrearTorneo.TabIndex = 5;
            this.buttonCrearTorneo.Text = "Crear Torneo";
            this.buttonCrearTorneo.UseVisualStyleBackColor = true;
            this.buttonCrearTorneo.Click += new System.EventHandler(this.buttonCrearTorneo_Click_1);
            // 
            // buttonAdministrarTorneo
            // 
            this.buttonAdministrarTorneo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdministrarTorneo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAdministrarTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonAdministrarTorneo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAdministrarTorneo.Location = new System.Drawing.Point(412, 320);
            this.buttonAdministrarTorneo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAdministrarTorneo.Name = "buttonAdministrarTorneo";
            this.buttonAdministrarTorneo.Size = new System.Drawing.Size(149, 62);
            this.buttonAdministrarTorneo.TabIndex = 6;
            this.buttonAdministrarTorneo.Text = "Administrar Torneo";
            this.buttonAdministrarTorneo.UseVisualStyleBackColor = true;
            this.buttonAdministrarTorneo.Click += new System.EventHandler(this.buttonAdministrarTorneo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::BoxManager.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(526, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Image = global::BoxManager.Properties.Resources.Logo;
            this.pictureBoxMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxMenu.Location = new System.Drawing.Point(64, 12);
            this.pictureBoxMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(431, 133);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 13;
            this.pictureBoxMenu.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAdministrarTorneo);
            this.Controls.Add(this.buttonCrearTorneo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCatDiv);
            this.Controls.Add(this.buttonHistorial);
            this.Controls.Add(this.buttonReporteBoxeadores);
            this.Controls.Add(this.buttonBoxeadores);
            this.Controls.Add(this.pictureBoxMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boxing Manager V0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonReporteBoxeadores;
        private System.Windows.Forms.Button buttonBoxeadores;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Button buttonCatDiv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAgregarCateDiv;
        private System.Windows.Forms.Button buttonAgregarBoxeador;
        private System.Windows.Forms.Label labelCantAcciones;
        private System.Windows.Forms.Label labelCantDivisiones;
        private System.Windows.Forms.Label labelCantCategorias;
        private System.Windows.Forms.Label labelCantBoxeadores;
        private System.Windows.Forms.Label labelBuscarNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonHistorial;
        private System.Windows.Forms.Button buttonCrearTorneo;
        private System.Windows.Forms.Button buttonAdministrarTorneo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

