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
            dvCtPro.DataSource = logRol.Instancia.ListarCategoriaProducto();

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() != "")
                {
                    int categoriaId = int.Parse(txtID.Text);
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta categoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        bool eliminado = logCategoriaProducto.Instancia.EliminarCategoriaProducto(categoriaId);
                        if (eliminado)
                        {
                            MessageBox.Show("Categoría eliminada con éxito.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la categoría.");
                        }
                        mostrarDgv();
                        limpiarI();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una categoría para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarI();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
