/* Enunciado:
             * 60)	Crear un método que muestre un array
             */
int[] numeros = { 5, 10, 3, 8, 2 };

MostrarArray(numeros);

Console.ReadKey();

void MostrarArray(int[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("El array esta vacio");
    }
    else
    {
        foreach (int numero in array)
        {
            Console.WriteLine(numero);
        }
    }
}