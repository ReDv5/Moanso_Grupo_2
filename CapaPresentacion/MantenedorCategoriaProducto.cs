using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class MantenedorCategoriaProducto : Form
    {
        public MantenedorCategoriaProducto()
        {
            InitializeComponent();
            mostrarDgv();
            txtID.Enabled = false;
            limpiarI();

        }
        public void mostrarDgv()
        {
            dgvCtPro.DataSource = logCategoriaProducto.Instancia.ListarCategoriaProducto();

        }
        public void limpiarI()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDesc.Text = "";
            btnModificar.Enabled = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoriaProducto c = new entCategoriaProducto();
                c.nombre = txtNombre.Text.Trim();
                c.descripcion = txtDesc.Text.Trim();
                bool i = logCategoriaProducto.Instancia.InsertaCategoriaProducto(c);
                if (i == true)
                {
                    MessageBox.Show("Insertado con éxito.");
                }
                else
                {
                    MessageBox.Show("No se pudo insertar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            mostrarDgv();
            limpiarI();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoriaProducto c = new entCategoriaProducto();
                c.categoria_id = int.Parse(txtID.Text);
                c.nombre = txtNombre.Text.Trim();
                c.descripcion = txtDesc.Text.Trim();
                bool i = logCategoriaProducto.Instancia.EditaCategoriaProducto(c);
                if (i == true)
                {
                    MessageBox.Show("Modificado con éxito.");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            mostrarDgv();
            limpiarI();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarI();
        }

        private void txtCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoriaProducto c = new entCategoriaProducto();
                c.categoria_id = int.Parse(txtID.Text);
                c.nombre = txtNombre.Text.Trim();
                c.descripcion = txtDesc.Text.Trim();
                bool i = logCategoriaProducto.Instancia.EditaCategoriaProducto(c);

                if (i == true)
                {
                    MessageBox.Show("Modificado con éxito.");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            mostrarDgv();
            limpiarI();
        }
    }
}
