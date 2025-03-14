/* Enunciado:
             * 27)	Mostrar los números del 1 al 100, sustituyendo los 
             * múltiplos de 3 por la palabra "Fizz" y los múltiplos de
             * 5 por la palabra "Buzz". Tener en cuenta que aquellos 
             * múltiples por ambos números mostraran la frase "FizzBuzz".
             */
for (int i = 1; i <= 100; i++)
{
    bool multiplo3 = false;
    bool multiplo5 = false;
    if (i % 3 == 0) multiplo3 = true;
    if (i % 5 == 0) multiplo5 = true;
    if (multiplo3 && multiplo5) Console.WriteLine($"{i} - FizzBuzz");
    if (multiplo3) Console.WriteLine($"{i} - Fizz");
    if (multiplo5) Console.WriteLine($"{i} - Buzz");
}
Console.ReadKey();