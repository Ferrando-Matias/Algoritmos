int[] numeros = { 5, 10, 3, 8, 2 };

int menor = ObtenerMenor(numeros);

Console.WriteLine($"El número mayor es: {menor}");

Console.ReadKey();
int ObtenerMenor(int[] array)
{
    int menor = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < menor)
        {
            menor = array[i];
        }
    }

    return menor;
}