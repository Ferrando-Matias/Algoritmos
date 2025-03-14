/* Enunciado:
             * 22)	Calcular la suma siguiente:	100 + 98 + 96 + 94 + . . . + 0 en este orden
             */
int suma = 0;
for (int i = 100; i >= 0; i -= 2)
{
    suma += i;
}
Console.WriteLine(suma);
Console.ReadKey();