/* Enunciado:
             * 38)	Crea un programa que solicite al usuario el tamaño de dos arrays 
             * y los valores para cada uno de sus elementos. Luego, el programa debe 
             * mostrar en la consola los elementos de ambos arrays en un solo array 
             * combinado y ordenado de forma decreciente
             */
Console.Write("Ingrese el tamaño del primer array: ");
int tamaño1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el tamaño del segundo array: ");
int tamaño2 = int.Parse(Console.ReadLine());

int[] array1 = new int[tamaño1];
int[] array2 = new int[tamaño2];

Console.WriteLine("Ingrese los valores para el primer array:");
for (int i = 0; i < tamaño1; i++)
{
    Console.Write($"Valor {i + 1}: ");
    array1[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Ingrese los valores para el segundo array:");
for (int i = 0; i < tamaño2; i++)
{
    Console.Write($"Valor {i + 1}: ");
    array2[i] = int.Parse(Console.ReadLine());
}

int tamaño3 = tamaño1 + tamaño2;
int[] array3 = new int[tamaño3];

for (int i = 0; i < tamaño1; i++)
{
    array3[i] = array1[i];
}

for (int i = 0; i < tamaño2; i++)
{
    array3[tamaño1 + i] = array2[i];
}

Array.Sort(array3);
Array.Reverse(array3);

Console.WriteLine("El array combinado y ordenado de forma decreciente es:");
for (int i = 0; i < tamaño3; i++)
{
    Console.Write(array3[i] + " ");
}
Console.ReadKey();