using System;

/* Metodos:
            - Procedimientos (No devuelve nada - VOID)
            - Funciones (SI devuelve un valor - Tipo de Dato)
*/
// 1. Procedimiento: no devuelve valor

void ejemplo()
{

}

void MostrarMensaje(string mensaje)
{
    Console.WriteLine(mensaje);    
}


// 2. Función: devuelve un valor
int Sumar(int a, int b)
{
    int suma = a + b;
    //return suma;    
    return a + b;
}

// 3. Parámetros por valor (por defecto en C#)
void MultiplicarPorDos(int numero)
{
    numero = numero * 2; // Esto no afectará al valor original fuera del método
    Console.WriteLine($"Número dentro del método: {numero}");
}

// 4. Parámetros por referencia (modifica el valor original fuera del método)
void MultiplicarPorDosRef(ref int numero)
{
    numero = numero * 2; // Modifica el valor original
    Console.WriteLine($"Número dentro del método (ref): {numero}");
}

// 5. Parámetros de salida (out): permite devolver más de un valor
void CalcularAreaYPerimetro(int ancho, int alto, out int area, out int perimetro)
{
    area = ancho * alto;
    perimetro = 2 * (ancho + alto);
}

// 6. Parámetros obligatorios y opcionales
void Saludar(string nombre, string saludo = "Hola", string titulo = "Por defecto")
{
    Console.WriteLine(titulo);
    Console.WriteLine($"{saludo}, {nombre}!");
}


// 1. Llamada a un procedimiento
MostrarMensaje("Este es un mensaje.");

// 2. Llamada a una función
int resultadoSuma = Sumar(5, 7);
Console.WriteLine($"La suma es: {resultadoSuma}");

// 3. Parámetros por valor (el valor original no cambia)
int numero = 10;
MultiplicarPorDos(numero);
Console.WriteLine($"Número fuera del método: {numero}");

// 4. Parámetros por referencia (el valor original cambia)
int numeroRef = 10;
MultiplicarPorDosRef(ref numeroRef);
Console.WriteLine($"Número fuera del método (ref): {numeroRef}");

// 5. Parámetros de salida (out)
int area, perimetro;
CalcularAreaYPerimetro(5, 10, out area, out perimetro);
Console.WriteLine($"Área: {area}, Perímetro: {perimetro}");

// 6. Parámetros obligatorios y opcionales
Saludar("Carlos"); // Usará el saludo por defecto
Saludar("Carlos", "Buenas tardes"); // Usará el saludo personalizado
Saludar("Carlos", "Buenas tardes", "Nuevo titulo"); // Usará el saludo personalizado
Saludar("Matias", titulo:"Mensaje de Bienvenida" );

