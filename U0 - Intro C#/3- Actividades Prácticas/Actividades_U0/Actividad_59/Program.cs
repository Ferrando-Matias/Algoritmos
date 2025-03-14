/* Enunciado:
             * 59)	Crear un método que sume dos números pasados por parámetros, devolverá el resultado
             */
double num1 = 5;
double num2 = 5;
Console.WriteLine($"El total de la suma es de {Suma(num1, num2)}");
Console.ReadKey();


double Suma(double x, double y)
{
    return x + y;
}