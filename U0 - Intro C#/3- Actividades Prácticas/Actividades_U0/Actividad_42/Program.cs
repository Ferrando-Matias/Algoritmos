/* Enunciado:
             * 42)	Escribe un programa que solicite al usuario dos matrices iguales 
             * de tamaño n x m y las sume. El resultado debe ser una matriz de tamaño
             * n x m, donde cada elemento sea la suma de los elementos correspondientes
             * de las matrices de entrada.
             */

Console.Write("Ingrese el número de filas (n): ");
int filas = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número de columnas (m): ");
int columnas = int.Parse(Console.ReadLine());

int[,] matriz1 = new int[filas, columnas];
int[,] matriz2 = new int[filas, columnas];

Console.WriteLine("Ingrese los valores para la primera matriz:");
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write($"Valor [{i + 1}, {j + 1}]: ");
        matriz1[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Ingrese los valores para la segunda matriz:");
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write($"Valor [{i + 1}, {j + 1}]: ");
        matriz2[i, j] = int.Parse(Console.ReadLine());
    }
}

int[,] matrizSuma = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        matrizSuma[i, j] = matriz1[i, j] + matriz2[i, j];
    }
}

Console.WriteLine("La matriz resultante de la suma es:");
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write(matrizSuma[i, j] + " ");
    }
    Console.WriteLine();
}
Console.ReadKey();