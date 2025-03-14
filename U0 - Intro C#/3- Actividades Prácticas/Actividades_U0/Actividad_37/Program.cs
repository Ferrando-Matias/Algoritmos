/* Enunciado:
             * 37)	Dado un array de números, con el método Sort, ordenarlos y mostrar su contenido.  
             */

int[] numeros = new int[] { 10, 2, 35, 4, 15 };
Array.Sort(numeros);
foreach (var num in numeros)
{
    Console.WriteLine(num);
}
Console.ReadKey();