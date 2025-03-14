using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class CL_Localidades
    {
        public DataTable Buscar (string localidad = null)
        {
            DataTable resultado = new DataTable ();
            CD_BuscarLocalidad localidades = new CD_BuscarLocalidad ();

            if (localidades != null) resultado = localidades.buscarLocalidad(localidad);
            else resultado = localidades.cargarTodas();

            return resultado;
        }
    }
}
