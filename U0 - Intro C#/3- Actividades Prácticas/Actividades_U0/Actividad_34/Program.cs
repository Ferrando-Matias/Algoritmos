/* Enunciado:
             * 34)	Crea un programa que solicite al usuario el tamaño de un array 
             * y los valores para cada uno de sus elementos. Luego, el programa 
             * debe mostrar la suma de todos los elementos del array
             */
Console.WriteLine("Ingrese la cantidad de numeros a guardar");
int cant = Convert.ToInt32(Console.ReadLine());
int[] numeros = new int[cant];
int suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Ingrese un numero");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int num in numeros)
{
    suma += num;
}
Console.WriteLine($"La suma de los numeros guardados es de: {suma}");
Console.ReadKey();