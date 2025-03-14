using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPOO
{
    internal abstract class Caballo : Mamiferos
    {
        // "base" le pasa al constructor de la clase padre lo que recibe este constructor
        public Caballo(string nombreCaballo) : base (nombreCaballo)
        {
            
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("El caballo relincha");
        }
    }
}
