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
    public partial class MantenedorProducto : Form
    {
        public MantenedorProducto()
        {
            InitializeComponent();
        }

        public void mostrarDgv()
        {
            dgvProducto.DataSource = logProducto.Instancia.ListarProducto();

        }

        public void limpiarI()
        {
            txtProducto.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtEstado.Text = "";
            btnEditar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto p = new entProducto();
                p.nombre = txtNombre.Text.Trim();
                p.descirpcion = txtDescripcion.Text.Trim();
                p.precio_unidad = double.Parse(txtPrecio.Text.Trim());
                p.estado = txtEstado.Text.Trim();
                p.categoria_id = int.Parse(txtCategoria.Text.Trim());
                bool i = logProducto.Instancia.InsertaProducto(p);
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
            mostrarDgv();
            limpiarI();
        }

    
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entProducto p = new entProducto();
                p.producto_id = int.Parse(txtProducto.Text);
                p.nombre = txtNombre.Text.Trim();
                p.descirpcion = txtDescripcion.Text.Trim();
                p.precio_unidad = double.Parse(txtPrecio.Text.Trim());
                p.estado = txtEstado.Text.Trim();
                p.categoria_id = int.Parse(txtCategoria.Text.Trim());
                bool i = logProducto.Instancia.EditaProducto(p);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiarI();
        }
    }
}
