/* Enunciado:
             * 16)	Pedirle al usuario 10 números, contar los positivos y sumar los negativos. 
             * Informar ambos resultados
             */
int contPos = 0, sumNeg = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese el numero {0}", i + 1);
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        contPos++;
    }
    else
    {
        sumNeg += num;
    }
}
Console.WriteLine("Cantidad positivos: {0} \nSuma Negativos: {1}", contPos, sumNeg);
Console.ReadKey();