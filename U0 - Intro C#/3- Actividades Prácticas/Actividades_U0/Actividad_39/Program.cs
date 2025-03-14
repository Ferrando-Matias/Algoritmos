/* Enunciado:
             * 39)	Crea un programa que solicite al usuario el tamaño 
             * de un array y los valores para cada uno de sus elementos.
             * Luego, el programa debe encontrar el valor máximo y 
             * mínimo del array y mostrarlos en la consola.
             */

Console.Write("Ingrese el tamaño del array: ");
int tamaño = int.Parse(Console.ReadLine());

int[] array = new int[tamaño];

Console.WriteLine("Ingrese los valores para el array:");
for (int i = 0; i < tamaño; i++)
{
    Console.Write($"Valor {i + 1}: ");
    array[i] = int.Parse(Console.ReadLine());
}

int max = int.MinValue;
int min = int.MaxValue;

for (int i = 0; i < tamaño; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }

    if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine("El valor máximo del array es: " + max);
Console.WriteLine("El valor mínimo del array es: " + min);
Console.ReadKey();