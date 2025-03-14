using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPOO
{
    internal class Humano : Mamiferos
    {
        // "base" le pasa al constructor de la clase padre lo que recibe este constructor
        public Humano(string NombreHumano) : base (NombreHumano) { }

        public override void EmitirSonido()
        {
            Console.WriteLine("El humano habla");
        }
    }
}
