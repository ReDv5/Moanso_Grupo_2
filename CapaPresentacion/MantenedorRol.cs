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
    public partial class MantenedorRol : Form
    {
        public MantenedorRol()
        {
            InitializeComponent();
            mostrarDgv();
            txtIdRol.Enabled = false;
            limpiarI();
        }
        public void mostrarDgv()
        {
            dgvRol.DataSource = logRol.Instancia.ListarRol();

        }
        public void limpiarI()
        {
            txtIdRol.Text = "";
            txtNombreRol.Text = "";
            btnEditarRol.Enabled = false;
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            try
            {
                
                entRol r = new entRol();
                r.nombre = txtNombreRol.Text.Trim();
                bool i = logRol.Instancia.InsertaRol(r);
                if(i == true)
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
        private void dgvRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvRol.Rows[e.RowIndex];
            txtIdRol.Text = filaActual.Cells[0].Value.ToString();
            txtNombreRol.Text = filaActual.Cells[1].Value.ToString();
        }


        private void txtIdRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarRol_Click(object sender, EventArgs e)
        {
            limpiarI();
        }

        private void btnEditarRol_Click(object sender, EventArgs e)
        {
            
            try
            {
                entRol r = new entRol();
                r.nombre = txtNombreRol.Text.Trim();
                r.rol_id = int.Parse(txtIdRol.Text);
                bool i = logRol.Instancia.InsertaRol(r);
                if (i == true)
                {
                    MessageBox.Show("Modificado con Exito.");
                }
                else
                {
                    MessageBox.Show("No se pudo Modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            mostrarDgv();
            limpiarI();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            btnEditarRol.Enabled = true;
        }
    }
}
