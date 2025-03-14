/* Enunciado:
             * 24)	Solicitar al usuario que ingrese un número entero positivo y mostrar la suma de los números pares del 1 al número ingresado.
             */
int suma = 0;
Console.WriteLine("Ingrese un numero entero positivo");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < num; i++)
{
    if (i % 2 == 0)
    {
        suma += i;
    }
}
Console.WriteLine("La suma de los numeros pares es de: " + suma);
Console.ReadKey();