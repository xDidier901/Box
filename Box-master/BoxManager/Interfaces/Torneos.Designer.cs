namespace BoxManager.Interfaces
{
    partial class Torneos
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarTorneo = new System.Windows.Forms.Button();
            this.btnGanador = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(12, 599);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(87, 37);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(45, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 47);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarTorneo
            // 
            this.btnGuardarTorneo.BackColor = System.Drawing.Color.White;
            this.btnGuardarTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTorneo.Location = new System.Drawing.Point(45, 320);
            this.btnGuardarTorneo.Name = "btnGuardarTorneo";
            this.btnGuardarTorneo.Size = new System.Drawing.Size(114, 47);
            this.btnGuardarTorneo.TabIndex = 11;
            this.btnGuardarTorneo.Text = "Guardar torneo";
            this.btnGuardarTorneo.UseVisualStyleBackColor = false;
            // 
            // btnGanador
            // 
            this.btnGanador.BackColor = System.Drawing.Color.White;
            this.btnGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanador.Location = new System.Drawing.Point(45, 152);
            this.btnGanador.Name = "btnGanador";
            this.btnGanador.Size = new System.Drawing.Size(114, 47);
            this.btnGanador.TabIndex = 10;
            this.btnGanador.Text = "Ganador";
            this.btnGanador.UseVisualStyleBackColor = false;
            this.btnGanador.Click += new System.EventHandler(this.btnGanador_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(219, 49);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(813, 587);
            this.dataGridView.TabIndex = 9;
            // 
            // Torneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 665);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarTorneo);
            this.Controls.Add(this.btnGanador);
            this.Controls.Add(this.dataGridView);
            this.Name = "Torneos";
            this.Text = "Torneos";
            this.Load += new System.EventHandler(this.Torneos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarTorneo;
        private System.Windows.Forms.Button btnGanador;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}