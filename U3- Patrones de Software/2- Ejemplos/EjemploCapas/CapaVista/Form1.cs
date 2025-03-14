using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaVista
{
    public partial class Form1 : Form
    {
        CL_Localidades localidades = new CL_Localidades();

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.SteelBlue;

            DGVLocalidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona toda la fila al hacer click en cualquier celda
            DGVLocalidades.MultiSelect = false; //desactiva la seleccion multiple
            DGVLocalidades.AllowUserToAddRows = false; //desactiva  la ultima fila para evitar que el usuario agregue datos a la grilla manualmente
            DGVLocalidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;    // Ajuste automatico para todas las columnas visibles
            DGVLocalidades.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;    // Ajuste automatico para todas las filas visibles
            DGVLocalidades.BorderStyle = BorderStyle.None;    // Estilo de los bordes del datagrid
            DGVLocalidades.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;    // Estilo de los bordes de las celdas
            DGVLocalidades.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Estilo de las columnas del encabezado
            DGVLocalidades.ColumnHeadersHeight = 30;  // Alto del encabezado
            DGVLocalidades.GridColor = Color.SteelBlue;   // Color de las lineas divisorias
            DGVLocalidades.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;    // Estilo de la fila de encabezado
            DGVLocalidades.RowHeadersVisible = false; //Elimino las cabeceras de las filas
            DGVLocalidades.ForeColor = Color.DarkBlue;
            DGVLocalidades.BackgroundColor = Color.SteelBlue;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DGVLocalidades.DataSource = localidades.Buscar(txtLocalidad.Text.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            try
            {
                txtLocalidad.Clear();
                DGVLocalidades.DataSource = localidades.Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                    DGVLocalidades.DataSource = localidades.Buscar(txtLocalidad.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLocalidad.Select();    // Alternativa al Focus() cuando el control se encuentra dentro de un contenedor
        }
    }
}
