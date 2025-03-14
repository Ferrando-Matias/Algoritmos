using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosUnidad1_UI_
{
    public partial class FrmTP72 : Form
    {
        const string Us = "Algoritmos";
        const string Pww = "1234";
        public FrmTP72()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Algoritmos" && txtContra.Text == "1234")
            {
                MessageBox.Show("Acceso Permitido");
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
        }
    }
}
