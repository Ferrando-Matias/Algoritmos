/* Enunciado:
             * 45)	Escribe un programa que solicite al usuario una matriz 
             * cuadrada y muestre por pantalla la suma de los elementos de
             * su diagonal principal y diagonal secundaria (es decir, los 
             * elementos que se encuentran en la diagonal que va desde la 
             * esquina superior derecha a la inferior izquierda).
             */

Console.Write("Ingrese el tamaño de la matriz cuadrada: ");
int tamaño = int.Parse(Console.ReadLine());

int[,] matriz = new int[tamaño, tamaño];

Console.WriteLine("Ingrese los valores para la matriz:");
for (int i = 0; i < tamaño; i++)
{
    for (int j = 0; j < tamaño; j++)
    {
        Console.Write($"Valor [{i + 1}, {j + 1}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

int sum = 0;

for (int i = 0; i < tamaño; i++)
{
    sum += matriz[i, i]; // Sumar elemento de la diagonal principal
    sum += matriz[i, tamaño - i - 1]; // Sumar elemento de la diagonal secundaria
}

Console.WriteLine("La suma de los elementos de la diagonal principal y diagonal secundaria es: " + sum);
Console.ReadKey();