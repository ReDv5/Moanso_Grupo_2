using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class MantenedorTienda : Form
    {
        public MantenedorTienda()
        {
            InitializeComponent();
            mostrar();
            Limpiar();
        }
        public void mostrar()
        {
            dgvTienda.DataSource = logTienda.Instancia.ListarRol();
        }

        public void Limpiar()
        {
            txtIdTienda.Enabled = false;
            txtNombreTienda.Enabled = false;
            txtUbicacionTienda.Enabled = false;
            txtIdTienda.Text = "";
            txtNombreTienda.Text = "";
            txtUbicacionTienda.Text = "";
            btnEditar.Enabled = false;
            btnInsertarTienda.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnInsertarTienda.Enabled = true;
        }

        private void btnModificarTienda_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
        }

        private void btnInsertarTienda_Click(object sender, EventArgs e)
        {
            try
            {

                entTienda t = new entTienda();
                t.nombre = txtNombreTienda.Text.Trim();
                t.ubicacion = txtUbicacionTienda.Text.Trim();
                bool i = logTienda.Instancia.InsertaTienda(t);
                if (i == true)
                {
                    MessageBox.Show("Insertado con Exito");
                }
                else
                {
                    MessageBox.Show("No se pudo insertar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            mostrar();
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                entTienda t = new entTienda();
                t.tienda_id = int.Parse(txtIdTienda.Text.Trim());
                t.nombre = txtNombreTienda.Text.Trim();
                t.ubicacion = txtUbicacionTienda.Text.Trim();
                bool i = logTienda.Instancia.EditaTienda(t);
                if (i == true)
                {
                    MessageBox.Show("Editado con Exito");
                }
                else
                {
                    MessageBox.Show("No se pudo Editar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            mostrar();
            Limpiar();
        }
    }
}
