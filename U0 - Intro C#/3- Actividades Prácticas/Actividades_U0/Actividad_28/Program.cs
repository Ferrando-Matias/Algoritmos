/* Enunciado:
             * 28)	Solicitar al usuario que ingrese una palabra y mostrar
             * cada letra de la palabra en una línea separada
             */

Console.WriteLine("Ingrese una palabra"); 
string palabra = Console.ReadLine();
foreach (char letra in palabra)
{
    Console.WriteLine(letra);
}

Console.ReadKey();