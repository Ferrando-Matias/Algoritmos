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

namespace C__ADONet_Access
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
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

            txtLocalidad.Select();    // Alternativa al Focus() cuando el control se encuentra dentro de un contenedor
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarLocalidad(txtLocalidad.Text);           
        }

        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            txtLocalidad.Clear(); 
            cargarTodas();
        }

        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                buscarLocalidad(txtLocalidad.Text); 
        }

        private void cargarTodas()
        {
            //GENERO LOS OBJETOS DE CONEXION
            string cadenaConexion; //variable string para guardar la cadena de conexion
            OleDbConnection cnn; //Genero el objeto Connection (encargado del manejo de la conexion)
            OleDbDataAdapter da; //creo el objeto DataAdapter que traera los datos
            DataSet ds; //creo el objeto DataSet que contendra los datos obtenidos

            try
            {
                //cargo la cadena de conexion en el string
                cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|CVPC.accdb";
                //instancio el objeto Connection y le asigno la cadena
                cnn = new OleDbConnection(cadenaConexion);
                //me aseguro que el DataSet este vacio (por alguna secion anterior)
                if (cnn.State == ConnectionState.Open) cnn.Close(); // Si la conexion quedo abierta la cierro
                //abro la conexion
                cnn.Open();
                //escribo una consulta sql en una variable de tipo string
                string sSQL = "SELECT Localidades.Localidad, Localidades.Codigo_Postal as CP, Partidos.Partido, Provincias.Provincia" +
                                    " FROM(Provincias INNER JOIN Partidos ON Provincias.[Id_Provincia] = Partidos.[Id_Provincia])" +
                                    " INNER JOIN Localidades ON Partidos.[Id_Partido] = Localidades.[Id_Partido]";

                //instancio el objeto DataAdapter pasandole como parametro la
                //consulta sql y el objeto por el cual conectara
                da = new OleDbDataAdapter(sSQL, cnn);
                //instancio el objeto DataSet
                ds = new DataSet();
                //le paso los datos del DataAdapter al DataSet
                da.Fill(ds);
                //cierro la conexion
                cnn.Close();

                //enlazo el DataSet al DataGridView
                DGVLocalidades.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show(" ERROR al conectar a la BD");
            }
        }

        private void buscarLocalidad(string localidad)
        {
            try
            {
                string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|CVPC.accdb";

                string sSQL = @"SELECT Localidades.Localidad, Localidades.Codigo_Postal as CP, Partidos.Partido, Provincias.Provincia" +
                                    " FROM(Provincias INNER JOIN Partidos ON Provincias.[Id_Provincia] = Partidos.[Id_Provincia])" +
                                    " INNER JOIN Localidades ON Partidos.[Id_Partido] = Localidades.[Id_Partido] WHERE Localidades.Localidad like  ? ";
                // @Localidad"; El Parametro se puede colocar de ambas maneras
                // En SQL Server, los parametros se toman por el nombre definido en la consulta,
                // en el caso de access los tomara segun el ORDEN en que se agregan los parametros
                // al objeto command

                DataTable dt = new DataTable();

                using (OleDbConnection conn = new OleDbConnection(cadenaConexion))
                {
                    OleDbCommand command = new OleDbCommand(sSQL, conn);
                    command.Parameters.AddWithValue("Localidad", "%" + localidad + "%");
                    conn.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    da.Fill(dt);
                }
                //Enlazo el objeto DataTable al DataGridView
                DGVLocalidades.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("ERROR al conectar a la BD");
            }
        }
    }
}
