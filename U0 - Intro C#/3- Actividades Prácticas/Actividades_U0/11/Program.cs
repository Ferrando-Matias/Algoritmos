/* Enunciado:
             * 11)	Pedir al usuario un numero e informar si es positivo, negativo o cero 
             */
Console.WriteLine("Ingrese un numero");
int numero = Convert.ToInt32(Console.ReadLine());
if (numero > 0)
{
    Console.WriteLine("El numero es positivo");
}
else if (numero < 0)
{
    Console.WriteLine("El numero es negativo");
}
else
{
    Console.WriteLine("El numero es cero");
}
Console.ReadKey();