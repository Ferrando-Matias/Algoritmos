/* Enunciado:
             * 30)	Realizar un sistema que liste la tabla binaria (hasta el 1111) 
             * utilizando ciclos de repeticion
             */

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            for (int h = 0; h < 2; h++)
            {
                Console.WriteLine($"{i} {j} {k} {h}");
            }
        }
    }
}
Console.ReadKey();