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
using CapaEntidad;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class MantenedorEmpleado : Form
    {
        public MantenedorEmpleado()
        {
            InitializeComponent();
        }



        private void ListarEmpleados()
        {
            try
            {
                dgvEmpleados.DataSource = logEmpleado.Instancia.ListarEmpleado(); // Llama a la lógica de negocio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar empleados: " + ex.Message);
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarEmpleados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                entEmpleado emp = new entEmpleado
                {
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    telefono = int.Parse(txtTelefono.Text),
                    contacto = txtContacto.Text,
                    estado = txtEstado.Text,
                    rol_id = int.Parse(txtRolId.Text),
                    tienda_id = int.Parse(txtTiendaId.Text)
                };

                bool inserta = logEmpleado.Instancia.InsertaEmpleado(emp);
                if (inserta)
                {
                    MessageBox.Show("Empleado agregado correctamente.");
                    ListarEmpleados(); // Refresca la lista
                }
                else
                {
                    MessageBox.Show("Error al agregar el empleado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado emp = new entEmpleado
                {
                    empleado_id = int.Parse(dgvEmpleados.SelectedRows[0].Cells["empleado_id"].Value.ToString()),
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    telefono = int.Parse(txtTelefono.Text),
                    contacto = txtContacto.Text,
                    estado = txtEstado.Text,
                    rol_id = int.Parse(txtRolId.Text),
                    tienda_id = int.Parse(txtTiendaId.Text)
                };

                bool edita = logEmpleado.Instancia.EditaEmpleado(emp);
                if (edita)
                {
                    MessageBox.Show("Empleado modificado correctamente.");
                    ListarEmpleados(); // Refresca la lista
                }
                else
                {
                    MessageBox.Show("Error al modificar el empleado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            ListarEmpleados();
        }



        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                txtNombre.Text = dgvEmpleados.SelectedRows[0].Cells["nombre"].Value.ToString();
                txtApellido.Text = dgvEmpleados.SelectedRows[0].Cells["apellido"].Value.ToString();
                txtTelefono.Text = dgvEmpleados.SelectedRows[0].Cells["telefono"].Value.ToString();
                txtContacto.Text = dgvEmpleados.SelectedRows[0].Cells["contacto"].Value.ToString();
                txtEstado.Text = dgvEmpleados.SelectedRows[0].Cells["estado"].Value.ToString();
                txtRolId.Text = dgvEmpleados.SelectedRows[0].Cells["rol_id"].Value.ToString();
                txtTiendaId.Text = dgvEmpleados.SelectedRows[0].Cells["tienda_id"].Value.ToString();
            }
        }

    }
}