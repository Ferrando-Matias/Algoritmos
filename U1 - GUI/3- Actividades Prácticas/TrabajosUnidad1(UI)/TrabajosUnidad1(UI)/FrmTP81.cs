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
    public partial class FrmTP81 : Form
    {
        List <double> ventasSemanales = new List <double> ();
        public FrmTP81()
        {
            InitializeComponent();
        }
        private void soloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void limpiarControles(Control _control)
        {
            foreach (Control control in _control.Controls)
            {
                if (control is GroupBox grp) limpiarControles(grp);
                if (control is TextBox txt) txt.Clear();
                if (control is NumericUpDown nud) nud.Value = 1;
            }
        }

        private double calcularSueldo(double ventasSemana)
        {
            return 20000 + ventasSemana * 0.05;
        }

        private void txtPrecioUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtArticulo.Text != "" && txtPrecioUni.Text != "")
            {
                int unidades = Convert.ToInt32(nudUnidades.Value);
                double venta = Convert.ToDouble(txtPrecioUni.Text) * unidades;
                ventasSemanales.Add(venta);

                //Esto sera el texto que se añadira a la listbox.
                var nuevo_item = $"{txtArticulo.Text} (x{unidades}) / {venta}";
                lstArtiventas.Items.Add(nuevo_item);
                limpiarControles(this);
            }
            else
            {
                MessageBox.Show("Debe introducir el nombre del articulo y su precio unitario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }              

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles(this); //Paso todo el formulario para limpiar
            lstArtiventas.Items.Clear();
            lblRes.Text = "$ 0";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sueldo = calcularSueldo(ventasSemanales.Sum());
            lblRes.Text = $"$ {sueldo}";
            limpiarControles(this);
        }
    }
}
