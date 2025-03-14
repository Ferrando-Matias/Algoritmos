int[] numeros = { 5, 10, 3, 8, 2 };

int mayor = ObtenerMayor(numeros);

Console.WriteLine($"El número mayor es: {mayor}");
Console.ReadKey();
int ObtenerMayor(int[] array)
{
    int mayor = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > mayor)
        {
            mayor = array[i];
        }
    }

    return mayor;
}