/* Enunciado:
             * 44)	Escribe un programa que solicite al usuario una matriz 
             * cuadrada y muestre por pantalla los elementos de su diagonal 
             * principal (es decir, los elementos que se encuentran en la 
             * diagonal que va desde la esquina superior izquierda a la 
             * inferior derecha).
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

Console.WriteLine("La diagonal principal de la matriz es:");
for (int i = 0; i < tamaño; i++)
{
    Console.WriteLine(matriz[i, i]);
}
Console.ReadKey();