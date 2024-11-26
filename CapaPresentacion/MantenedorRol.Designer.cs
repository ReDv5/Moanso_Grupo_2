namespace CapaPresentacion
{
    partial class MantenedorRol
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
            this.dgvRol = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.btnEditarRol = new System.Windows.Forms.Button();
            this.btnLimpiarRol = new System.Windows.Forms.Button();
            this.txtCerrarRol = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRol
            // 
            this.dgvRol.AllowUserToAddRows = false;
            this.dgvRol.AllowUserToDeleteRows = false;
            this.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRol.Location = new System.Drawing.Point(23, 166);
            this.dgvRol.Name = "dgvRol";
            this.dgvRol.ReadOnly = true;
            this.dgvRol.RowHeadersWidth = 51;
            this.dgvRol.RowTemplate.Height = 24;
            this.dgvRol.Size = new System.Drawing.Size(400, 215);
            this.dgvRol.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID :";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(159, 25);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(100, 22);
            this.txtNombreRol.TabIndex = 3;
            // 
            // txtIdRol
            // 
            this.txtIdRol.Location = new System.Drawing.Point(109, 78);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.Size = new System.Drawing.Size(100, 22);
            this.txtIdRol.TabIndex = 4;
            this.txtIdRol.TextChanged += new System.EventHandler(this.txtIdRol_TextChanged);
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Location = new System.Drawing.Point(415, 41);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(94, 47);
            this.btnAgregarRol.TabIndex = 5;
            this.btnAgregarRol.Text = "Agregar";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // btnEditarRol
            // 
            this.btnEditarRol.Location = new System.Drawing.Point(545, 41);
            this.btnEditarRol.Name = "btnEditarRol";
            this.btnEditarRol.Size = new System.Drawing.Size(94, 47);
            this.btnEditarRol.TabIndex = 6;
            this.btnEditarRol.Text = "Editar";
            this.btnEditarRol.UseVisualStyleBackColor = true;
            this.btnEditarRol.Click += new System.EventHandler(this.btnEditarRol_Click);
            // 
            // btnLimpiarRol
            // 
            this.btnLimpiarRol.Location = new System.Drawing.Point(477, 133);
            this.btnLimpiarRol.Name = "btnLimpiarRol";
            this.btnLimpiarRol.Size = new System.Drawing.Size(94, 47);
            this.btnLimpiarRol.TabIndex = 7;
            this.btnLimpiarRol.Text = "Limpiar";
            this.btnLimpiarRol.UseVisualStyleBackColor = true;
            this.btnLimpiarRol.Click += new System.EventHandler(this.btnLimpiarRol_Click);
            // 
            // txtCerrarRol
            // 
            this.txtCerrarRol.Location = new System.Drawing.Point(507, 420);
            this.txtCerrarRol.Name = "txtCerrarRol";
            this.txtCerrarRol.Size = new System.Drawing.Size(94, 49);
            this.txtCerrarRol.TabIndex = 8;
            this.txtCerrarRol.Text = "Cerrar";
            this.txtCerrarRol.UseVisualStyleBackColor = true;
            this.txtCerrarRol.Click += new System.EventHandler(this.txtCerrarRol_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(485, 223);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(86, 51);
            this.btnModifica.TabIndex = 9;
            this.btnModifica.Text = "Modificar";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // MantenedorRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 498);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.txtCerrarRol);
            this.Controls.Add(this.btnLimpiarRol);
            this.Controls.Add(this.btnEditarRol);
            this.Controls.Add(this.btnAgregarRol);
            this.Controls.Add(this.txtIdRol);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRol);
            this.Name = "MantenedorRol";
            this.Text = "MantenedorRol";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.TextBox txtIdRol;
        private System.Windows.Forms.Button btnAgregarRol;
        private System.Windows.Forms.Button btnEditarRol;
        private System.Windows.Forms.Button btnLimpiarRol;
        private System.Windows.Forms.Button txtCerrarRol;
        private System.Windows.Forms.Button btnModifica;
    }
}