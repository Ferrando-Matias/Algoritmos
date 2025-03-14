using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPOO
{
    internal class Auto
    {
        private int ruedas;
        private int largo;
        private int ancho;
        private bool climatizador;
        private string tapizado;

        public Auto(int ruedas = 4)
        {
            this.ruedas = ruedas;
            largo = 5000;
            ancho = 1500;
        }
        public void SetRuedas(int ruedas)
        {
            this.ruedas = ruedas;
        }
        public int GetRuedas()
        {
            // Este método permite que podamos tomar un valor (Método Getter)
            return ruedas;   // El return devuelve un valor o sale del método
        }

        public int Ruedas { 
            get
            {
                return this.ruedas;
            }
            set
            {
                this.ruedas = value;
            }
        }

    }
}
