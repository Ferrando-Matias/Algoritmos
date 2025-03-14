// Ejemplo básico en C# con sintaxis de nivel superior en .NET 8
// Mostraremos el uso de variables, constantes, comentarios, sentencias, bloques, interacción con la consola, depuración, banderas y regiones.

#region Constantes y Variables
// Constantes: Valores que no pueden cambiar durante la ejecución del programa
const double PI = 3.1416;

// Variables: Pueden cambiar de valor durante la ejecución del programa
string? nombre; // Declaramos una variable de tipo texto (string) - El "?" indica que en esa variable se aceptan nulos
int edad;      // Declaramos una variable de tipo entero (int)
double radio;  // Declaramos una variable de tipo decimal (double) para el radio de un círculo 
#endregion

// Comentarios en una linea
/*
 * Esto es
 * Un comentario multilinea
 */

#region Interaccion con Consola
// Interacción con la consola: Pedimos información al usuario
Console.WriteLine("¡Hola! Por favor, ingresa tu nombre");
nombre = Console.ReadLine(); // Leemos el nombre ingresado por el usuario y lo guardamos en la variable 'nombre'

Console.WriteLine("¿Qué edad tienes?");
// Convertimos el valor ingresado a entero (ya que ReadLine siempre devuelve texto)
edad = int.Parse(Console.ReadLine());

Console.WriteLine("Por favor, ingresa el radio de un círculo:");
radio = double.Parse(Console.ReadLine()); // Convertimos el valor ingresado a decimal 
#endregion

#region Sentencias vs Bloques de codigo
// Sentencias y bloques: Usamos un bloque de código para realizar cálculos
// Calculamos el área de un círculo usando la constante PI
double area = PI * radio * radio; // Fórmula para el área de un círculo: Pi * r^2

if (area < 0)
{
    // Esto es un bloque, porque esta delimitado entre llaves
    Console.WriteLine("El area dio negativo");
}
#endregion

#region Informe de Resultados
// Mostramos los resultados en la consola
Console.WriteLine("\nResumen de tus datos:");
Console.WriteLine($"Nombre: {nombre}"); // Usamos interpolación de cadenas para mostrar variables dentro del texto
Console.WriteLine($"Edad: {edad} años");
Console.WriteLine($"El área del círculo con radio {radio} es {area}");
#endregion


// La depuración te permite detener la ejecución y revisar valores.
// Aquí podrías poner un punto de quiebre (breakpoint) para observar el valor de 'area' y de otras variables.

Console.ReadKey();