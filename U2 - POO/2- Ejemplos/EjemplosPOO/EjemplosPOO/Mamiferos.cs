using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPOO
{
    internal abstract class Mamiferos
    {
        private string nombreSerVivo;
        public Mamiferos(string nombre) 
        {
            this.nombreSerVivo = nombre;
        }

        public virtual void EmitirSonido()
        {
            Console.WriteLine("El mamifero emite un sonido");
        }
    }
}
