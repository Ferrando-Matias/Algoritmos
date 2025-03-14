using System;
using Tipos_datos_Conversiones_datos;

#region Tipos de Datos
const double PI = 3.1416;

//Declaracion de variable
// Tipo de dato - Nombre de la variable (preferentemente que identifique su contenido) - (opcional) una inicializacion

// Tipos de datos primitivos
// 1. Enteros
byte byteValor = 255;                // 8 bits, rango: 0 a 255
sbyte sbyteValor = -128;             // 8 bits con signo, rango: -128 a 127
short shortValor = 32767;            // 16 bits, rango: -32,768 a 32,767
ushort ushortValor = 65535;          // 16 bits sin signo, rango: 0 a 65,535
int intValor = 2147483647;           // 32 bits, rango: -2,147,483,648 a 2,147,483,647
uint uintValor = 4294967295;         // 32 bits sin signo, rango: 0 a 4,294,967,295
long longValor = 9223372036854775807; // 64 bits, rango: -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807
ulong ulongValor = 18446744073709551615; // 64 bits sin signo, rango: 0 a 18,446,744,073,709,551,615

// 2. Decimales
float floatValor = 3.40282347E+38F;  // 32 bits
double doubleValor = 1.7976931348623157E+308; // 64 bits
decimal decimalValor = 79228162514264337593543950335M; // 128 bits

// 3. Texto
char charValor = 'A';                // Un solo carácter
string stringValor = "Hola, C#";     // Cadena de texto

// 4. Booleano
bool boolValor = true;               // Verdadero o falso

// 5. Nullables
int? nullableInt = null;              // Entero anulable

// 6. Tipos de datos adicionales
object objectValor = "Soy un objeto"; // Tipo genérico que puede almacenar cualquier tipo
var varValor = 42;                    // Tipo implícito (var) asignado como int
dynamic dynamicValor = "Soy dinámico"; // Puede cambiar en tiempo de ejecución

// 7. Definido por el usuario
Persona persona = new Persona("Juan", 30); // Crear una instancia de Persona

Console.WriteLine("Tipos de Datos:");
Console.WriteLine($"byte: {byteValor}");
Console.WriteLine($"sbyte: {sbyteValor}");
Console.WriteLine($"short: {shortValor}");
Console.WriteLine($"ushort: {ushortValor}");
Console.WriteLine($"int: {intValor}");
Console.WriteLine($"uint: {uintValor}");
Console.WriteLine($"long: {longValor}");
Console.WriteLine($"ulong: {ulongValor}");
Console.WriteLine($"float: {floatValor}");
Console.WriteLine($"double: {doubleValor}");
Console.WriteLine($"decimal: {decimalValor}");
Console.WriteLine($"char: {charValor}");
Console.WriteLine($"string: {stringValor}");
Console.WriteLine($"bool: {boolValor}");
Console.WriteLine($"nullable int: {nullableInt}");
Console.WriteLine($"object: {objectValor}");
Console.WriteLine($"var: {varValor}");
Console.WriteLine($"dynamic: {dynamicValor}");
persona.MostrarInformacion(); // Mostrar información de la persona 
#endregion

#region Conversiones
Console.WriteLine("\nConversión de Datos:");

// **1. Conversión implícita**
double conversionImplicita1 = intValor; // int a double (sin pérdida de datos)
double conversionImplicita2 = floatValor; // float a double (sin pérdida de datos)

Console.WriteLine($"\nConversión implícita (int a double): {conversionImplicita1}");
Console.WriteLine($"Conversión implícita (float a double): {conversionImplicita2}");

// **2. Conversión explícita**
float conversionExplicita1 = (float)doubleValor; // double a float (pérdida de precisión)
int conversionExplicita2 = (int)doubleValor; // double a int (truncado)
byte conversionExplicita3 = (byte)byteValor; // byte a byte (mismo valor, no hay cambio)
short conversionExplicita4 = (short)intValor; // int a short (pérdida de datos posible)

Console.WriteLine($"\nConversión explícita (double a float): {conversionExplicita1}");
Console.WriteLine($"Conversión explícita (double a int): {conversionExplicita2}");
Console.WriteLine($"Conversión explícita (byte a byte): {conversionExplicita3}");
Console.WriteLine($"Conversión explícita (int a short): {conversionExplicita4}");

// **3. Conversión mediante la clase Convert**
int numberFromString = Convert.ToInt32("12345"); // string a int
string intToString = Convert.ToString(intValor);  // int a string
float stringToFloat = Convert.ToSingle("3.14");   // string a float

Console.WriteLine($"\nConversión mediante Convert (string a int): {numberFromString}");
Console.WriteLine($"Conversión mediante Convert (int a string): {intToString}");
Console.WriteLine($"Conversión mediante Convert (string a float): {stringToFloat}");

// Conversión segura
string valor = "1234";
//int parsedInt;
bool conversionExitosa = int.TryParse(valor, out int parsedInt); // string a int

Console.WriteLine($"\nConversión segura (int desde string): {conversionExitosa} - Valor: {parsedInt}");

#endregion


Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();

