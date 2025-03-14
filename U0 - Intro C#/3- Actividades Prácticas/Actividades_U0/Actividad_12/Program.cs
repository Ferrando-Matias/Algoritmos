/* Enunciado:
             * 12)	Realizar un programa que indique que tipo de triangulo es al ingresar los tres lados 
             */

Console.WriteLine("Ingrese el primer lado");
int lado1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo lado");
int lado2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el tercer lado");
int lado3 = Convert.ToInt32(Console.ReadLine());

if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("El triángulo es equilátero");
    }
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    {
        Console.WriteLine("El triángulo es isósceles");
    }
    else
    {
        Console.WriteLine("El triángulo es escaleno");
    }
}
else
{
    Console.WriteLine("Los lados ingresados no forman un triángulo válido");
}
Console.ReadKey();