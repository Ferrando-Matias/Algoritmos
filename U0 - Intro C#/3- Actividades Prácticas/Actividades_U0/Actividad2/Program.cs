/* ENUNCIADO:
             * 2)	Pedir por consola un nombre de persona y el nombre de una ciudad 
             * (no hace falta que sean reales o comprobarlos) y mostrar por pantalla, 
             * el siguiente mensaje “Hola  <nombre> bienvenido a <ciudad>“              
             */

Console.Write("Por favor ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.Write("Por favor ingrese su ciudad: ");
string ciudad = Console.ReadLine();
Console.Clear();
Console.WriteLine("Hola {0}, bienvenido a {1}", nombre, ciudad);
Console.ReadKey();