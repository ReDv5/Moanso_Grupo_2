namespace CapaPresentacion
{
    partial class MantenedorTienda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTienda = new System.Windows.Forms.DataGridView();
            this.txtIdTienda = new System.Windows.Forms.TextBox();
            this.txtNombreTienda = new System.Windows.Forms.TextBox();
            this.txtUbicacionTienda = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnInsertarTienda = new System.Windows.Forms.Button();
            this.btnModificarTienda = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ubicacion :";
            // 
            // dgvTienda
            // 
            this.dgvTienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienda.Location = new System.Drawing.Point(33, 209);
            this.dgvTienda.Name = "dgvTienda";
            this.dgvTienda.RowHeadersWidth = 51;
            this.dgvTienda.RowTemplate.Height = 24;
            this.dgvTienda.Size = new System.Drawing.Size(465, 200);
            this.dgvTienda.TabIndex = 3;
            // 
            // txtIdTienda
            // 
            this.txtIdTienda.Location = new System.Drawing.Point(108, 25);
            this.txtIdTienda.Name = "txtIdTienda";
            this.txtIdTienda.Size = new System.Drawing.Size(106, 22);
            this.txtIdTienda.TabIndex = 4;
            // 
            // txtNombreTienda
            // 
            this.txtNombreTienda.Location = new System.Drawing.Point(108, 67);
            this.txtNombreTienda.Name = "txtNombreTienda";
            this.txtNombreTienda.Size = new System.Drawing.Size(141, 22);
            this.txtNombreTienda.TabIndex = 5;
            // 
            // txtUbicacionTienda
            // 
            this.txtUbicacionTienda.Location = new System.Drawing.Point(108, 126);
            this.txtUbicacionTienda.Name = "txtUbicacionTienda";
            this.txtUbicacionTienda.Size = new System.Drawing.Size(390, 22);
            this.txtUbicacionTienda.TabIndex = 6;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(590, 26);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 33);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnInsertarTienda
            // 
            this.btnInsertarTienda.Location = new System.Drawing.Point(720, 25);
            this.btnInsertarTienda.Name = "btnInsertarTienda";
            this.btnInsertarTienda.Size = new System.Drawing.Size(94, 34);
            this.btnInsertarTienda.TabIndex = 8;
            this.btnInsertarTienda.Text = "Insertar";
            this.btnInsertarTienda.UseVisualStyleBackColor = true;
            this.btnInsertarTienda.Click += new System.EventHandler(this.btnInsertarTienda_Click);
            // 
            // btnModificarTienda
            // 
            this.btnModificarTienda.Location = new System.Drawing.Point(590, 87);
            this.btnModificarTienda.Name = "btnModificarTienda";
            this.btnModificarTienda.Size = new System.Drawing.Size(94, 33);
            this.btnModificarTienda.TabIndex = 9;
            this.btnModificarTienda.Text = "Modificar";
            this.btnModificarTienda.UseVisualStyleBackColor = true;
            this.btnModificarTienda.Click += new System.EventHandler(this.btnModificarTienda_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(720, 87);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 33);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(650, 154);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 34);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MantenedorTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnModificarTienda);
            this.Controls.Add(this.btnInsertarTienda);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtUbicacionTienda);
            this.Controls.Add(this.txtNombreTienda);
            this.Controls.Add(this.txtIdTienda);
            this.Controls.Add(this.dgvTienda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenedorTienda";
            this.Text = "MantenedorTienda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTienda;
        private System.Windows.Forms.TextBox txtIdTienda;
        private System.Windows.Forms.TextBox txtNombreTienda;
        private System.Windows.Forms.TextBox txtUbicacionTienda;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnInsertarTienda;
        private System.Windows.Forms.Button btnModificarTienda;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
    }
}