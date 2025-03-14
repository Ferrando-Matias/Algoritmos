/* Enunciado:
            * 31)	Pedirle al usuario una indeterminada cantidad de números 
            * del 1 al 10, e informar el promedio, el mayor y el menor, el 
            * sistema terminara al ingresar el numero 0 (Cero). 
            */
int mayor = int.MinValue, menor = int.MaxValue, suma = 0, cant = 0, promedio = 0;
do
{
    Console.Clear();
    int numero = 0;
    Console.WriteLine("Ingrese un numero del 1 al 10 o '0' para salir");
    if (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Error al convertir el numero - Presione enter para continuar");
        Console.ReadKey();
        continue;
    }
    if (numero == 0) break;
    if (numero < 0 || numero > 10)
    {
        Console.WriteLine("Numero fuera de los parametros - Presione enter para continuar");
        Console.ReadKey();
        continue;
    }
    if (numero < menor) menor = numero;
    if (numero > mayor) mayor = numero;
    suma += numero;
    cant++;
} while (true);

promedio = suma / cant;
Console.WriteLine($"El numero mayor fue: {mayor}\n" +
    $"El numero menor fue {menor}\n" +
    $"El promedio es: {promedio}");

Console.ReadKey();