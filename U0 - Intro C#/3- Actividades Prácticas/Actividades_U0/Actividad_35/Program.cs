/* Enunciado:
             * 35)	Crea un programa que solicite al usuario el tamaño de un array
             * y los valores para cada uno de sus elementos. Luego, el programa debe
             * calcular la media de los elementos del array y mostrarla en la consola. 
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
int promedio = suma / numeros.Length;
Console.WriteLine($"La