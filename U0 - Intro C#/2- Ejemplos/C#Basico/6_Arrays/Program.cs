using System;

// **Declaración e Instanciación de un Array Unidimensional**
int[] numeros = new int[5] ; // Declara un array de enteros con 5 elementos

// **Uso de la Propiedad Length**
Console.WriteLine("Longitud del array de números: " + numeros.Length); // Muestra la longitud


// **Recorrido para Llenar un Array**
for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = i * 10; // Asigna valores (0, 10, 20, 30, 40)
}

// **Lectura de un Array con For**
Console.WriteLine("Lectura del array con For:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento en la posición {i}: {numeros[i]}"); // Muestra cada elemento
}

// **Lectura de un Array con ForEach**
Console.WriteLine("Lectura del array con ForEach:");
foreach (int numero in numeros)
{
    Console.WriteLine($"Número: {numero}"); // Muestra cada número
}

// **Arrays Implícitos**
var frutas = new[] { "Manzana", "Naranja", "Plátano" }; // Declara un array implícito de cadenas
Console.WriteLine("Frutas:");
foreach (var fruta in frutas)
{
    Console.WriteLine(fruta); // Muestra cada fruta
}

// **Array Bidimensional**
int[,] matriz = new int[2, 3]; // Declara una matriz de 2x3
matriz[0, 0] = 1; // Asigna valores a la matriz
matriz[0, 1] = 2;
matriz[0, 2] = 3;
matriz[1, 0] = 4;
matriz[1, 1] = 5;
matriz[1, 2] = 6;

// **Lectura de un Array Bidimensional**
Console.WriteLine("Matriz:");
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
   {
        Console.Write($"{matriz[i, j]} "); // Muestra cada elemento de la matriz
    }
    Console.WriteLine();
}

// **Uso de la Clase Array**
Array.Sort(numeros); // Ordena ascendentemente el array de números
Console.WriteLine("Array ordenado:");
foreach (int numero in numeros)
{
    Console.WriteLine(numero); // Muestra el array ordenado
}

Array.Reverse(numeros); // Invierte el array
Console.WriteLine("Array invertido:");
foreach (int numero in numeros)
{
    Console.WriteLine(numero); // Muestra el array invertido
}

// **Uso de BinarySearch**
int indice = Array.BinarySearch(numeros, 20); // Busca el número 20
Console.WriteLine("Índice de 20: " + indice); // Muestra el índice encontrado

// **Uso de Find**
int encontrado = Array.Find(numeros, n => n > 20); // Busca el primer número mayor que 20
Console.WriteLine("Primer número mayor que 20: " + encontrado); // Muestra el número encontrado

// **Uso de GetLength**
Console.WriteLine("Número de filas en la matriz: " + matriz.GetLength(0)); // Muestra el número de filas: GetLength(0) para la dimension 1, GetLength(1) para la dimension 2...sucesivamente

// **Uso de Rank**
Console.WriteLine("Número de dimensiones de la matriz: " + matriz.Rank); // Muestra el número de dimensiones

// **Uso de Clear**
Array.Clear(numeros, 0, numeros.Length); // Limpia todos los elementos del array de números
Console.WriteLine("Array después de Clear:");
foreach (int numero in numeros)
{
    Console.WriteLine(numero); // Muestra el array después de limpiar
}

// **Uso de Resize**
Array.Resize(ref numeros, 10); // Cambia el tamaño del array a 10
Console.WriteLine("Array después de Resize (tamaño 10):");
foreach (int numero in numeros)
{
    Console.WriteLine(numero); // Muestra el array redimensionado (los nuevos elementos son 0)
}
