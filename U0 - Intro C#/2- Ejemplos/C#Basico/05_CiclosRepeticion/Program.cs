
// Ciclos de repeticion

// Ciclo FOR
int numero = 0;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Ingrese un numero");
    numero += Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(numero);

for (int i = 100; i >= 1; i -= 10)
{
    Console.WriteLine(i);
}

string texto = "Hola Mundo!";
Console.WriteLine(texto);
Console.WriteLine("---------------------------------");
Console.WriteLine("For");
for (int i = 0; i < texto.Length; i++) // Itera sobre cada carácter del string
{
    char letra = texto[i]; // Obtiene el carácter en la posición i
    if (letra == 'M') // Condición para el uso de break
    {
        break; // Sale del ciclo si encuentra 'M'
    }
    Console.WriteLine(letra); // Muestra cada letra
}
Console.WriteLine("---------------------------------");
Console.WriteLine("ForEach");
// **Ejemplo de ciclo ForEach**
foreach (char letra in texto) // Recorre cada carácter del string
{
    if (letra == 'M') // Condición para el uso de continue
    {
        continue; // Salta la coma y continúa con la siguiente iteración
    }
    Console.WriteLine(letra); // Muestra cada letra, excepto la coma
}
Console.WriteLine("---------------------------------");

Console.WriteLine("While");
// **Ejemplo de ciclo While**
int j = 0; // Inicializa el contador
while (j < texto.Length) // Mientras j sea menor que la longitud del string
{
    char letra = texto[j]; // Obtiene el carácter en la posición j
    Console.WriteLine(letra); // Muestra cada letra
    j++; // Incrementa el contador
}
Console.WriteLine("---------------------------------");
Console.WriteLine("DoWhile");
// **Ejemplo de ciclo Do While**
int k = 0; // Inicializa el contador
do
{
    char letra = texto[k]; // Obtiene el carácter en la posición k
    if (letra == 'o') // Condición para el uso de return
    {
        return; // Sale del programa (en este contexto) si encuentra 'o'
    }
    Console.WriteLine(letra); // Muestra cada letra
    k++; // Incrementa el contador
} while (k < texto.Length); // Continúa mientras k sea menor que la longitud del string
