using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto corsa = new Auto(5);
            corsa.SetRuedas(6);
            corsa.Ruedas = 7;
            Console.WriteLine(corsa.Ruedas);

            Entity entity = new Entity();
            Console.WriteLine(entity.GetSerialNo());
            Entity.SetNextSerialNo(5);
            Entity entity2 = new Entity();
            Console.WriteLine(entity2.GetSerialNo());
            Entity entity3 = new Entity();
            Console.WriteLine(Entity.GetNextSerialNo());

            Empleado juan = new Empleado();
            juan.SALARIO = 15000;       // Se aplica el método Set
            Console.WriteLine(juan.SALARIO);		// Se aplica el método Get

            Mamiferos mamifero1 = new Humano("Matias");
            mamifero1.EmitirSonido();

            Mamiferos mamifero2 = new Caballo("Relampago");
            mamifero2.EmitirSonido();







            Console.ReadKey();
        }
    }
}
