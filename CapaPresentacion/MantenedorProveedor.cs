using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class MantenedorProveedor : Form
    {
        public MantenedorProveedor()
        {
            InitializeComponent();
            mostrarDgv();
            limpiarI();
        }

        public void mostrarDgv()
        {
            dgvProveedor.DataSource = logProveedor.Instancia.ListarProveedor();

        }

        public void limpiarI()
        {
            txtProveedor.Text = "";
            txtNombre.Text = "";
            txtContacto.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEstado.Text = "";
            btnModificar.Enabled = false;
        }


        private void MantenedorProveedor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.proveedor_id = int.Parse(txtProveedor.Text);
                p.contacto = txtContacto.Text.Trim();
                p.telefono = int.Parse(txtTelefono.Text.Trim());
                p.direccion = txtDireccion.Text.Trim();
                p.estado = txtEstado.Text.Trim();
                bool i = logProveedor.Instancia.EditaProveedor(p);
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
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.nombre = txtNombre.Text.Trim();
                p.contacto = txtContacto.Text.Trim();
                p.telefono = int.Parse(txtTelefono.Text.Trim());
                p.direccion = txtDireccion.Text.Trim();
                p.estado = txtEstado.Text.Trim();
                bool i = logProveedor.Instancia.InsertaProveedor(p);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarI();
        }
    }
}
