/* Enunciado:
             * 43)	Escribe un programa que solicite al usuario una matriz
             * cuadrada de tamaño n x n y la muestre por pantalla en su forma
             * }transpuesta, es decir, donde las filas se convierten en 
             * columnas y viceversa.
             */
Console.Write("Ingrese el tamaño de la matriz cuadrada (n): ");
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

Console.WriteLine("La matriz original es:");
for (int i = 0; i < tamaño; i++)
{
    for (int j = 0; j < tamaño; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

int[,] matrizTranspuesta = new int[tamaño, tamaño];

for (int i = 0; i < tamaño; i++)
{
    for (int j = 0; j < tamaño; j++)
    {
        matrizTranspuesta[j, i] = matriz[i, j];
    }
}

Console.WriteLine("La matriz transpuesta es:");
for (int i = 0; i < tamaño; i++)
{
    for (int j = 0; j < tamaño; j++)
    {
        Console.Write(matrizTranspuesta[i, j] + " ");
    }
    Console.WriteLine();
}
Console.ReadKey();