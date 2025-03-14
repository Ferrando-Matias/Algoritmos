using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_BuscarLocalidad : CD_Conexion
    {
        public DataTable cargarTodas()
        {
            OleDbDataAdapter da; 
            DataSet ds = new DataSet(); 

            try
            {
                AbrirConexion();
                string sSQL = "SELECT Localidades.Localidad, Localidades.Codigo_Postal as CP, Partidos.Partido, Provincias.Provincia" +
                                    " FROM(Provincias INNER JOIN Partidos ON Provincias.[Id_Provincia] = Partidos.[Id_Provincia])" +
                                    " INNER JOIN Localidades ON Partidos.[Id_Partido] = Localidades.[Id_Partido]";

                da = new OleDbDataAdapter(sSQL, CN);
                da.Fill(ds);
            }
            catch 
            {
               throw new Exception("ERROR al conectar a la BD");
            }
            finally
            {
                CerrarConexion();
            }
            return ds.Tables[0];

        }

        public DataTable buscarLocalidad(string localidad)
        {
            DataTable dt = new DataTable();
            try
            {               
                string sSQL = @"SELECT Localidades.Localidad, Localidades.Codigo_Postal as CP, Partidos.Partido, Provincias.Provincia" +
                                    " FROM(Provincias INNER JOIN Partidos ON Provincias.[Id_Provincia] = Partidos.[Id_Provincia])" +
                                    " INNER JOIN Localidades ON Partidos.[Id_Partido] = Localidades.[Id_Partido] WHERE Localidades.Localidad like  ? ";

                    OleDbCommand command = new OleDbCommand(sSQL, CN);
                    command.Parameters.AddWithValue("Localidad", "%" + localidad + "%");
                AbrirConexion();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);
                da.Dispose();
                command.Dispose();
            }
            catch
            {
               throw new Exception("ERROR al conectar a la BD");
            }
            finally
            {
                CerrarConexion();
            }
            return dt;
        }
    }
}
