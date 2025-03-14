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
    public partial class FrmTP69 : Form
    {
        double n1, n2, resultado;
        public FrmTP69()
        {
            InitializeComponent();
        }

        public void FiltroDeNumeros(object sender, KeyPressEventArgs e)
        {
            //Esto evita que se introduzcan letras.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //Esto puede aceptar comas y mmenos para la negatividad.
                if (e.KeyChar != '.' && e.KeyChar != '-')
                    e.Handled = true;
                else
                {
                    //Obviamente solo aceptara hasta una coma.
                    if (e.KeyChar == '.')
                    {
                        if ((sender as TextBox).Text.IndexOf('.') > -1)
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            if ((sender as TextBox).Text.IndexOf('-') > -1)
                            {
                                e.Handled = true;
                                (sender as TextBox).Text += e.KeyChar;
                            }
                        }
                    }
                    if (e.KeyChar == '-') //Aparte de verificar por negativos, se insertara como el caracter de la izquierda.
                    {
                        //Solo lo hara si solo hay un solo -.
                        if ((sender as TextBox).Text.IndexOf('-') > -1)
                        {
                            e.Handled = true;
                        }
                        else
                        { //Reescribe la propiedad text para que el menos este detras.
                            e.Handled = true;
                            (sender as TextBox).Text = "-" + (sender as TextBox).Text;
                        }
                    }
                }
            }
            else
            {
                //Esto va a comprobar si hay un " - " en algun punto de la string para evitar
                //que se posicione el numero atras del " - ".
                if ((sender as TextBox).Text.IndexOf('-') > -1 && char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    (sender as TextBox).Text += e.KeyChar;
                }
            }
        }

        private void txtN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltroDeNumeros(sender, e);
        }

        private void txtN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltroDeNumeros(sender, e);
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            resultado = n1 + n2;
            lblRes.Text = resultado.ToString("F2");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            resultado = n1 - n2;
            lblRes.Text = resultado.ToString("F2");
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            resultado = n1 * n2;
            lblRes.Text = resultado.ToString("F2");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            resultado = n1 / n2;
            lblRes.Text = resultado.ToString("F2");
        }
    }
}
