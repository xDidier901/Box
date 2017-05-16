﻿namespace BoxManager
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
            this.buttonRegistros = new System.Windows.Forms.Button();
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
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReporteBoxeadores
            // 
            this.buttonReporteBoxeadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReporteBoxeadores.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonReporteBoxeadores.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonReporteBoxeadores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonReporteBoxeadores.Location = new System.Drawing.Point(387, 199);
            this.buttonReporteBoxeadores.Name = "buttonReporteBoxeadores";
            this.buttonReporteBoxeadores.Size = new System.Drawing.Size(199, 76);
            this.buttonReporteBoxeadores.TabIndex = 8;
            this.buttonReporteBoxeadores.Text = "Reporte Boxeadores";
            this.buttonReporteBoxeadores.UseVisualStyleBackColor = true;
            this.buttonReporteBoxeadores.Click += new System.EventHandler(this.buttonCrearTorneo_Click);
            // 
            // buttonBoxeadores
            // 
            this.buttonBoxeadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBoxeadores.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonBoxeadores.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonBoxeadores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBoxeadores.Location = new System.Drawing.Point(12, 199);
            this.buttonBoxeadores.Name = "buttonBoxeadores";
            this.buttonBoxeadores.Size = new System.Drawing.Size(199, 76);
            this.buttonBoxeadores.TabIndex = 7;
            this.buttonBoxeadores.Text = "Boxeadores";
            this.buttonBoxeadores.UseVisualStyleBackColor = true;
            this.buttonBoxeadores.Click += new System.EventHandler(this.buttonBoxeadores_Click);
            // 
            // buttonCatDiv
            // 
            this.buttonCatDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCatDiv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCatDiv.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonCatDiv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCatDiv.Location = new System.Drawing.Point(12, 301);
            this.buttonCatDiv.Name = "buttonCatDiv";
            this.buttonCatDiv.Size = new System.Drawing.Size(199, 76);
            this.buttonCatDiv.TabIndex = 14;
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
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 187);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros";
            this.groupBox1.Visible = false;
            // 
            // buttonRegistros
            // 
            this.buttonRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistros.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRegistros.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonRegistros.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRegistros.Location = new System.Drawing.Point(387, 408);
            this.buttonRegistros.Name = "buttonRegistros";
            this.buttonRegistros.Size = new System.Drawing.Size(199, 76);
            this.buttonRegistros.TabIndex = 42;
            this.buttonRegistros.Text = "Registros (DLL)";
            this.buttonRegistros.UseVisualStyleBackColor = true;
            this.buttonRegistros.Click += new System.EventHandler(this.buttonRegistros_Click);
            // 
            // buttonAgregarCateDiv
            // 
            this.buttonAgregarCateDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregarCateDiv.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarCateDiv.Location = new System.Drawing.Point(211, 80);
            this.buttonAgregarCateDiv.Name = "buttonAgregarCateDiv";
            this.buttonAgregarCateDiv.Size = new System.Drawing.Size(35, 57);
            this.buttonAgregarCateDiv.TabIndex = 42;
            this.buttonAgregarCateDiv.Text = "+";
            this.buttonAgregarCateDiv.UseVisualStyleBackColor = true;
            this.buttonAgregarCateDiv.Click += new System.EventHandler(this.buttonAgregarCateDiv_Click);
            // 
            // buttonAgregarBoxeador
            // 
            this.buttonAgregarBoxeador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregarBoxeador.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarBoxeador.Location = new System.Drawing.Point(211, 43);
            this.buttonAgregarBoxeador.Name = "buttonAgregarBoxeador";
            this.buttonAgregarBoxeador.Size = new System.Drawing.Size(35, 28);
            this.buttonAgregarBoxeador.TabIndex = 41;
            this.buttonAgregarBoxeador.Text = "+";
            this.buttonAgregarBoxeador.UseVisualStyleBackColor = true;
            this.buttonAgregarBoxeador.Click += new System.EventHandler(this.buttonAgregarBoxeador_Click);
            // 
            // labelCantAcciones
            // 
            this.labelCantAcciones.AutoSize = true;
            this.labelCantAcciones.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantAcciones.Location = new System.Drawing.Point(153, 155);
            this.labelCantAcciones.Name = "labelCantAcciones";
            this.labelCantAcciones.Size = new System.Drawing.Size(18, 20);
            this.labelCantAcciones.TabIndex = 37;
            this.labelCantAcciones.Text = "0";
            this.labelCantAcciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCantDivisiones
            // 
            this.labelCantDivisiones.AutoSize = true;
            this.labelCantDivisiones.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantDivisiones.Location = new System.Drawing.Point(153, 117);
            this.labelCantDivisiones.Name = "labelCantDivisiones";
            this.labelCantDivisiones.Size = new System.Drawing.Size(18, 20);
            this.labelCantDivisiones.TabIndex = 36;
            this.labelCantDivisiones.Text = "0";
            this.labelCantDivisiones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCantCategorias
            // 
            this.labelCantCategorias.AutoSize = true;
            this.labelCantCategorias.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantCategorias.Location = new System.Drawing.Point(153, 84);
            this.labelCantCategorias.Name = "labelCantCategorias";
            this.labelCantCategorias.Size = new System.Drawing.Size(18, 20);
            this.labelCantCategorias.TabIndex = 35;
            this.labelCantCategorias.Text = "0";
            this.labelCantCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCantBoxeadores
            // 
            this.labelCantBoxeadores.AutoSize = true;
            this.labelCantBoxeadores.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantBoxeadores.Location = new System.Drawing.Point(153, 51);
            this.labelCantBoxeadores.Name = "labelCantBoxeadores";
            this.labelCantBoxeadores.Size = new System.Drawing.Size(18, 20);
            this.labelCantBoxeadores.TabIndex = 34;
            this.labelCantBoxeadores.Text = "0";
            this.labelCantBoxeadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBuscarNombre
            // 
            this.labelBuscarNombre.AutoSize = true;
            this.labelBuscarNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarNombre.Location = new System.Drawing.Point(6, 51);
            this.labelBuscarNombre.Name = "labelBuscarNombre";
            this.labelBuscarNombre.Size = new System.Drawing.Size(115, 20);
            this.labelBuscarNombre.TabIndex = 25;
            this.labelBuscarNombre.Text = "Boxeadores:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Categorías:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Divisiones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Acciones:";
            // 
            // buttonHistorial
            // 
            this.buttonHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHistorial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHistorial.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonHistorial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonHistorial.Location = new System.Drawing.Point(12, 408);
            this.buttonHistorial.Name = "buttonHistorial";
            this.buttonHistorial.Size = new System.Drawing.Size(199, 76);
            this.buttonHistorial.TabIndex = 11;
            this.buttonHistorial.Text = "Historial de Acciones";
            this.buttonHistorial.UseVisualStyleBackColor = true;
            this.buttonHistorial.Click += new System.EventHandler(this.buttonHistorial_Click);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Image = global::BoxManager.Properties.Resources.Logo;
            this.pictureBoxMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxMenu.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(574, 164);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 13;
            this.pictureBoxMenu.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 511);
            this.Controls.Add(this.buttonRegistros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCatDiv);
            this.Controls.Add(this.buttonHistorial);
            this.Controls.Add(this.buttonReporteBoxeadores);
            this.Controls.Add(this.buttonBoxeadores);
            this.Controls.Add(this.pictureBoxMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boxing Manager V0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button buttonRegistros;
    }
}
