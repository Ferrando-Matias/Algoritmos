/* Enunciado: 
             * 20)	Solicitar al usuario que ingrese un número entero positivo y 
             * mostrar la tabla de multiplicar correspondiente. 
             */
Console.WriteLine("Ingrese un numero entero positivo");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    for (int i = 1; i < 11; i++)
    {
        int res = num * i;
        Console.WriteLine("{0} * {1} = {2}", num, i, res);
    }
}
else
{
    Console.WriteLine("Error al elegir el numero");
}
Console.ReadKey();