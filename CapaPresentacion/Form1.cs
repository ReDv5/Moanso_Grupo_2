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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenedorRol mr = new MantenedorRol();
            mr.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MantenedorEmpleado me = new MantenedorEmpleado();   
            me.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MantenedorCategoriaProducto mcp = new MantenedorCategoriaProducto();
            mcp.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MantenedorProveedor mp = new MantenedorProveedor(); 
            mp.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MantenedorTienda mt = new MantenedorTienda();
            mt.Visible = true;
        }
    }
}
