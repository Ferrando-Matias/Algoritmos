using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosUnidad1_UI_
{
    public partial class FrmTP77 : Form
    {
        public FrmTP77()
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

        private void DatosInvisibles()
        {
            lblDato1.Visible = false;
            lblDato2.Visible = false;
            lblDato3.Visible = false;
            lblDato4.Visible = false;
            lblTipoTriangulo.Visible = false;
            lblTriangulo.Visible = false;

            txtDato1.Visible = false;
            txtDato2.Visible = false;
            txtDato3.Visible = false;
            txtDato4.Visible = false;
        }

        private double areaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        private double perimetroCirculo(double radio)
        {
            return 2 * Math.PI * radio;
        }

        private double areaRectangulo(double _base, double altura)
        {
            return _base * altura;
        }

        private double perimetroRectangulo(double _base, double altura)
        {
            return _base * 2 + altura * 2;
        }

        private double areaCuadrado(double lado)
        {
            return lado * lado;
        }

        private double perimetroCuadrado(double lado)
        {
            return lado * 4;
        }

        private double areaTriangulo(double _base, double altura)
        {
            return _base * altura / 2;
        }

        private double perimetroTriangulo(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 + lado3;
        }

        private string tipoTriangulo(double lado1, double lado2, double lado3)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return "Equilátero";
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }
                
        private void FrmTP77_Load(object sender, EventArgs e)
        {
            cmbFormas.Items.Add("Seleccione una forma");
            cmbFormas.Items.Add("Triangulo");
            cmbFormas.Items.Add("Cuadrado");
            cmbFormas.Items.Add("Rectangulo");
            cmbFormas.Items.Add("Circulo");
            cmbFormas.SelectedIndex = 0;

            DatosInvisibles();

        }

        private void cmbFormas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFormas.SelectedIndex)
            {
                case 1:
                    lblDato1.Text = "Base";
                    lblDato2.Text = "Lado 1";
                    lblDato3.Text = "Lado 2";
                    lblDato4.Text = "Altura";

                    lblDato1.Visible = true;
                    lblDato2.Visible = true;
                    lblDato3.Visible = true;
                    lblDato4.Visible = true;
                    lblTriangulo.Visible = true;
                    lblTipoTriangulo.Visible = true;

                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = true;
                    txtDato4.Visible = true;
                    break;
                case 2:
                    lblDato1.Text = "Lado";
                    lblDato1.Visible = true;
                    lblDato2.Visible = false;
                    lblDato3.Visible = false;
                    lblDato4.Visible = false;
                    lblTriangulo.Visible = false;
                    lblTipoTriangulo.Visible = false;

                    txtDato1.Visible = true;
                    txtDato2.Visible = false;
                    txtDato3.Visible = false;
                    txtDato4.Visible = false;
                    break;
                case 3:
                    lblDato1.Text = "Base";
                    lblDato2.Text = "Altura";

                    lblDato1.Visible = true;
                    lblDato2.Visible = true;
                    lblDato3.Visible = false;
                    lblDato4.Visible = false;
                    lblTriangulo.Visible = false;
                    lblTipoTriangulo.Visible = false;

                    txtDato1.Visible = true;
                    txtDato2.Visible = true;
                    txtDato3.Visible = false;
                    txtDato4.Visible = false;
                    break;
                case 4:
                    lblDato1.Text = "Radio";
                    lblDato1.Visible = true;
                    lblDato2.Visible = false;
                    lblDato3.Visible = false;
                    lblDato4.Visible = false;
                    lblTriangulo.Visible = false;
                    lblTipoTriangulo.Visible = false;

                    txtDato1.Visible = true;
                    txtDato2.Visible = false;
                    txtDato3.Visible = false;
                    txtDato4.Visible = false;
                    break;
                default:
                    DatosInvisibles();
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double dato1, dato2, dato3, dato4;

            switch (cmbFormas.SelectedIndex)
            {
                case 1:
                    dato1 = Convert.ToDouble(txtDato1.Text);
                    dato2 = Convert.ToDouble(txtDato2.Text);
                    dato3 = Convert.ToDouble(txtDato3.Text);
                    dato4 = Convert.ToDouble(txtDato4.Text);
                    lblArea.Text = areaTriangulo(dato1, dato4).ToString("F2");
                    lblPerimetro.Text = perimetroTriangulo(dato1, dato2, dato3).ToString("F2");
                    lblTipoTriangulo.Text = tipoTriangulo(dato1, dato2, dato3);
                    break;
                case 2:
                    dato1 = Convert.ToDouble(txtDato1.Text);
                    lblArea.Text = areaCuadrado(dato1).ToString("F2");
                    lblPerimetro.Text = perimetroCuadrado(dato1).ToString("F2");
                    break;
                case 3:
                    dato1 = Convert.ToDouble(txtDato1.Text);
                    dato2 = Convert.ToDouble(txtDato2.Text);
                    lblArea.Text = areaRectangulo(dato1, dato2).ToString("F2");
                    lblPerimetro.Text = perimetroRectangulo(dato1, dato2).ToString("F2");
                    break;
                case 4:
                    dato1 = Convert.ToDouble(txtDato1.Text);
                    lblArea.Text = areaCirculo(dato1).ToString("F2");
                    lblPerimetro.Text = perimetroCirculo(dato1).ToString("F2");
                    break;
                default:
                    MessageBox.Show("Debe seleccionar una figura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void txtDato1_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtDato2_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtDato3_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtDato4_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DatosInvisibles();
            txtDato1.Clear();
            txtDato2.Clear();
            txtDato3.Clear();
            txtDato4.Clear();
            lblArea.Text = "0";
            lblPerimetro.Text = "0";
            cmbFormas.SelectedIndex = 0;
        }
    }
}
