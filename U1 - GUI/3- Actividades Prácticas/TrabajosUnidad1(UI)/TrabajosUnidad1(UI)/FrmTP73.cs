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
    public partial class FrmTP73 : Form
    {
        public FrmTP73()
        {
            InitializeComponent();
        }
        private int ContadorCaracteres(string texto)
        {
            return texto.Count();
        }

        private int ContadorPalabras(string texto)
        {
            if (texto != "")
                // Split: Dividir el texto en palabras utilizando espacios en blanco como separadores
                // StringSplitOptions.RemoveEmptyEntries elimina las cadenas vacías resultantes
                return texto.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Count();
            else
                return 0;
        }

        private int ContadorEspacios(string texto)
        {
            return texto.Count(Char.IsWhiteSpace);
        }
        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            lblCaracteres.Text = ContadorCaracteres(txtTexto.Text).ToString();
            lblEspacios.Text = ContadorEspacios(txtTexto.Text).ToString("X");
            lblPalabras.Text = ContadorPalabras(txtTexto.Text).ToString("X");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
        }

        private void btnAlinIzq_Click(object sender, EventArgs e)
        {
            txtTexto.TextAlign = HorizontalAlignment.Left;
        }

        private void btnAlinCen_Click(object sender, EventArgs e)
        {
            txtTexto.TextAlign = HorizontalAlignment.Center;
        }

        private void btnAlinDer_Click(object sender, EventArgs e)
        {
            txtTexto.TextAlign = HorizontalAlignment.Right;
        }
    }
}
