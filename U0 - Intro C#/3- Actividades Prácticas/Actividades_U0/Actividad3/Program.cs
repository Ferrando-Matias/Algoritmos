/*ENUNCIADO
             * 3)	Pedir por consola tu nombre y tu edad y mostrar el 
             * siguiente mensaje: “Te llamas <nombre> y tienes <años> años”
             */

Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.Write("Ingrese su edad: ");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Te llamas {0} y tienes {1} años", nombre, edad);
Console.ReadKey();