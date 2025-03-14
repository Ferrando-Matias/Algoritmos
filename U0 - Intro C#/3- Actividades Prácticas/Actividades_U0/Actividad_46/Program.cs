/* Enunciado:
             * 46)	Pedir al usuario que ingrese una lista de números 
             * enteros y luego sumar todos los elementos de la lista.
             */
Console.Write("Ingrese una lista de números enteros separados por espacios: ");
string entrada = Console.ReadLine();

string[] numeros = entrada.Split(' ');

List<int> listaNumeros = new List<int>();

foreach (string numero in numeros)
{
    if (int.TryParse(numero, out int numeroEntero))
    {
        listaNumeros.Add(numeroEntero);
    }
    else
    {
        Console.WriteLine("Se ha ingresado un valor inválido. Ignorando...");
    }
}

int suma = 0;

foreach (int numero in listaNumeros)
{
    suma += numero;
}

Console.WriteLine("La suma de los números es: " + suma);
Console.ReadKey();