/* Enunciado:
             * 19)	Recorre los números del 1 al 100. Muestra los números divisibles entre 3
             */
for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}
Console.ReadKey();