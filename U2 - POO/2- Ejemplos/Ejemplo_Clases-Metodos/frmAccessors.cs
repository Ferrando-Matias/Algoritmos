using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Clases_Metodos
{
    public partial class frmAccessors : Form
    {
        #region Atributos
        // Creo un objeto del tipo de la clase Accesors y lo instancio llamando al constructor vacio por defecto
        Accessors objeto = new Accessors();   
        #endregion

        #region Constructor/es
        public frmAccessors()
        {
            InitializeComponent();

            // Modifico propiedades del formulario (utilizando this para referirme al mismo)
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
        } 
        #endregion

        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            // Modifico propiedades de los Labels
            lblEdad.Text = "Edad";
            lblResultado.Visible = false;
            lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void btnGetterSetter_Click(object sender, EventArgs e)
        {
            // Guardo el valor ingresado por el usuario utilizando el metodo SetEdad() que recibe datos enteros
            objeto.SetEdad(Convert.ToInt32(nmrEdad.Value));

            // Modifico el texto del Label adjuntandole el valor obtenido a traves del metodo GetEdad()
            lblResultado.Text = "Valor modificado por metodo SetEdad \ny obtenido por el metodo GetEdad:\n" + objeto.GetEdad();

            // Pongo visible el Label
            lblResultado.Visible = true;
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            // Guardo el valor ingresado por el usuario utilizando la Property
            objeto.Edad = Convert.ToInt32(nmrEdad.Value);

            // Modifico el texto del Label adjuntandole el valor obtenido a traves de la Property
            lblResultado.Text = "Valor modificado y obtenido por la Property Edad: \n" + objeto.Edad;

            // Pongo visible el Label
            lblResultado.Visible = true;
        }
        #endregion
    }
}
