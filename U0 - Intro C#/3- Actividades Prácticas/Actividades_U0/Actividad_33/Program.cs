/* Enunciado:
            * 33)	Crea un array de 10 posiciones, pide los valores por consola y muestra el array. 
            */

int[] numeros = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese un numero");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int num in numeros)
{
    Console.WriteLine(num);
}
Console.ReadKey();