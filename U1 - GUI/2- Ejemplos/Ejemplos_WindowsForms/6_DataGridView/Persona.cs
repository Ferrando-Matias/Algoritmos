using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DataGridView
{
    internal class Persona
    {
        public int Identificador { get; set; }
        public string Apellido { get; set; } = string.Empty; // Al no poder ser nulo se inicializa con un string vacío
        public string? Nombres { get; set; }  // "?" Permite valores nulos
        public int DNI { get; set; }
        public bool Baja { get; set; }
    }
}
