/* Enunciado:
             * 36)	Pedir un numero por teclado, multiplicarlo por todos 
             * los valores de un array y mostrar los resultados de cada multiplicacion. 
             */

int[] numeros = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine("Ingrese un numero");
int numero = Convert.ToInt32(Console.ReadLine());
foreach (var num in numeros)
{
    int multiplicacion = num * numero;
    Console.WriteLine($"La multiplicacion de {numero} * {num} es: {multiplicacion}");
}
Console.ReadKey();