using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos_WindowsForms
{
    public partial class frmMesageBox : Form
    {

        /* variable de ambito de clase tipo DialogResult donde se guardaran 
        * las respuestas de qué boton seleccionó el usuario en el cuadro de 
        * mensajes (Ok, Cancel, Aceptar...), necesaria para codificar segun 
        * la respuesta.
        */
        DialogResult Resultado;

        public frmMesageBox()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Mensaje simple de un solo botón
            MessageBox.Show("Mensaje con boton: Aceptar \n Icono: Error/Stop/Hand", // mensaje
                "Titulo Ventana",                   // titulo
                MessageBoxButtons.OK,               // tipo de boton
                MessageBoxIcon.Error);        // tipo icono

            //Mensaje simple donde podríamos obviar El titulo, el tipo de boton y el icono
            MessageBox.Show("Esto es un mensaje simple");            
        }

        private void btnAceptarCancelar_Click(object sender, EventArgs e)
        {
            Resultado = MessageBox.Show("Mensaje con botones Aceptar y Cancelar \n Icono: Asterisk / Information", // mensaje
                "Ejemplo Mensaje OKCanccel",        // titulo
                MessageBoxButtons.OKCancel,         // tipo boton
                MessageBoxIcon.Asterisk,            // tipo icono
                MessageBoxDefaultButton.Button1);   // Botón predeterminado       

            if (Resultado == DialogResult.OK)
            {
                MessageBox.Show("Seleccionaste Aceptar");
            }
            else
            {
                MessageBox.Show("Seleccionaste Cancelar");
                return; //Con este comando, dejamos lo que estuvieramos haciendo sin efecto
            }
        }

        private void btnSiNo_Click(object sender, EventArgs e)
        {
            Resultado = MessageBox.Show("Mensaje con botones Si / No \n Icono Exclamation / Warniing",
                "Ejemplo Mensaje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (Resultado == DialogResult.Yes)
            {
                MessageBox.Show("Seleccionaste Si");
            }
            else
            {
                MessageBox.Show("Seleccionaste No");
                return; //Con este comando, dejamos lo que estuvieramos haciendo sin efecto
            }
        }

        private void btnSiNoCancelar_Click(object sender, EventArgs e)
        {
            Resultado = MessageBox.Show("Mensaje con botones Sí, No y Cancelar \n Icono Question",
               "Ejemplo Mensaje YesNoCanccel",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Question);

            switch (Resultado)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Seleccionaste Si");
                    break;

                case DialogResult.No:
                    MessageBox.Show("Seleccionaste No");
                    return; //Con este comando, dejamos lo que estuvieramos haciendo sin efecto

                case DialogResult.Cancel:
                    MessageBox.Show("Seleccionaste Cancelar");
                    return;//Con este comando, dejamos lo que estuvieramos haciendo sin efecto

                default:
                    break;
            }
        }

        private void btnReintentarCancelar_Click(object sender, EventArgs e)
        {
            Resultado = MessageBox.Show("Mensaje con botones: \n Reintentar / Cancelar",
                "Ejemplo",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Stop);

            if (Resultado == DialogResult.Retry)
            {
                MessageBox.Show("Seleccionaste Reintentar");
            }
            else
            {
                MessageBox.Show("Seleccionaste Cancelar");
                return;
            }
        }

        private void btnAnularReintentarOmitir_Click(object sender, EventArgs e)
        {
            Resultado = MessageBox.Show("Mensaje con botones: \n Anular / Reintentar / Omitir",
               "Ejemplo Mensaje con 3 botones",
               MessageBoxButtons.AbortRetryIgnore,
               MessageBoxIcon.Exclamation);

            switch (Resultado)
            {
                case DialogResult.Abort:
                    MessageBox.Show("Seleccionaste Anular");
                    break;

                case DialogResult.Retry:
                    MessageBox.Show("Seleccionaste Reintentar");
                    return; //Con este comando, dejamos lo que estuvieramos haciendo sin efecto

                case DialogResult.Ignore:
                    MessageBox.Show("Seleccionaste Omitir");
                    return; //Con este comando, dejamos lo que estuvieramos haciendo sin efecto

                default:
                    break;
            }
        }

        private void MessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            Resultado = MessageBox.Show("Esta seguro de CERRAR la aplicación?",
                   "SALIR DEL SISTEMA",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Asterisk,
                   MessageBoxDefaultButton.Button2);

            if (Resultado == DialogResult.Cancel)
            {
                e.Cancel = true; //Cancela el cierre del formulario
            }
        }
    }
}
