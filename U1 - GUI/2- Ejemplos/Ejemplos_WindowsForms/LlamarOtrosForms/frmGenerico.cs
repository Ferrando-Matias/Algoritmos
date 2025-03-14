using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LlamarOtrosForms
{
    public partial class frmGenerico : Form
    {
        private string m_tabla;
        private string m_campo;
        public frmGenerico()
        {
            // Inicio los componentes del formulario
            InitializeComponent();
        }
        public frmGenerico(string Tabla, string Campo)
        {
            // Inicio los componentes del formulario
            InitializeComponent();

            // Guardo en las variables privadas los datos recibidos por parametros
            m_tabla = Tabla;
            m_campo = Campo;

        }

        private void frmGenerico_Load(object sender, EventArgs e)
        {
            this.Text = "Mantenimiento de " + m_tabla;
        }
    }
}
