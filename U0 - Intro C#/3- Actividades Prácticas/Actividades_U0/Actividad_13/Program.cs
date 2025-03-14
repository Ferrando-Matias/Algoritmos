/* Enunciado:
             * 13)	Pedir tres números al usuario, verificar que sean positivos, e informar su promedio
             */
Console.WriteLine("Ingrese un numero");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 >= 0 && num2 >= 0 && num3 >= 0)
{
    double promedio = (num1 + num2 + num3) / 3;
    Console.WriteLine("El promedio es: " + promedio);
}
else
{
    Console.WriteLine("Todos los numeros deben ser positivos");
}
Console.ReadKey();