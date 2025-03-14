using System.Text;

// Para valores decimales
float miFlotante = 0.8498948f;
double miDoble = 49889.4090409409;
decimal miDecimal = 12880000m;

// Booleano
bool miBooleano = false;

// Definir algunas cadenas
string cadena1 = "Hola";
string cadena2 = "Mundo";
string cadena3 = " C# es genial. ";
string cadenaVacia = "";

// Mostrar valores en consola con formato usando interpolacion
Console.WriteLine($"El valor entero es: {20,20}");
Console.WriteLine($"El valor flotante es: {miFlotante,20:P2}");
Console.WriteLine($"El valor doble es: {miDoble,20:N2}");
Console.WriteLine($"El valor decimal es: {miDecimal,20:C2}");
Console.WriteLine($"El valor booleano es: {(miBooleano ? "Verdadero" : "Falso")}");

// Concatenación usando +
string concatenado1 = cadena1 + ", " + cadena2 + "!";
Console.WriteLine($"Concatenación con '+': {concatenado1}");

// Concatenación usando String.Concat
string concatenado2 = string.Concat(cadena1, ", ", cadena2, "!");
Console.WriteLine($"Concatenación con String.Concat: {concatenado2}");

// Concatenación usando String.Join
string concatenado3 = string.Join(" ", cadena1, cadena2, "!");
Console.WriteLine($"Concatenación con String.Join: {concatenado3}");

// Concatenación usando StringBuilder
StringBuilder sb = new StringBuilder();
sb.Append(cadena1);
sb.Append(", ");
sb.Append(cadena2);
sb.Append("!");
string concatenado4 = sb.ToString();
Console.WriteLine($"Concatenación con StringBuilder: {concatenado4}");

// Interpolación de cadenas
string interpolacion = $"{cadena1}, {cadena2}!";
Console.WriteLine($"Concatenación con interpolación: {interpolacion}");

// String.Format
string formato = string.Format("{0}, {1}!", cadena1, cadena2);
Console.WriteLine($"Concatenación con String.Format: {formato}");

// Uso de métodos de la clase String
Console.WriteLine($"Comparación: {cadena1.CompareTo(cadena2)}"); // Salida de comparación
Console.WriteLine($"Concatenación: {string.Concat(cadena1, cadena3)}"); // Concatenación con otro método
Console.WriteLine($"¿Contiene 'Mundo'? {cadena2.Contains("Mundo")}"); // Contains
Console.WriteLine($"¿Termina con 'o'? {cadena1.EndsWith("o")}"); // EndsWith
Console.WriteLine($"¿Igual a 'hola'? {cadena1.Equals("hola", StringComparison.OrdinalIgnoreCase)}"); // Equals
Console.WriteLine($"Índice de 'M': {cadena2.IndexOf('M')}"); // IndexOf
Console.WriteLine($"Último índice de 'o': {cadena1.LastIndexOf('o')}"); // LastIndexOf
Console.WriteLine($"Longitud de '{cadena1}': {cadena1.Length}"); // Length
Console.WriteLine($"Eliminar 'a': {cadena1.Remove(1)}"); // Remove
Console.WriteLine($"Reemplazar 'Mundo' por 'C#': {cadena2.Replace("Mundo", "C#")}"); // Replace


string[] palabras = cadena3.Split(' '); // Split
Console.WriteLine("Palabras en cadena3:");
foreach (var palabra in palabras)
{
    Console.WriteLine(palabra); // Mostrar palabras
}
Console.WriteLine($"¿Empieza con 'Ho'? {cadena1.StartsWith("Ho")}"); // StartsWith
Console.WriteLine($"Subcadena de '{cadena2}': {cadena2.Substring(0, 3)}"); // Substring
Console.WriteLine($"Cadena en minúsculas: {cadena1.ToLower()}"); // ToLower
Console.WriteLine($"Cadena en mayúsculas: {cadena1.ToUpper()}"); // ToUpper
Console.WriteLine($"Trim de '{cadena3}': '{cadena3.Trim()}'"); // Trim
Console.WriteLine($"TrimStart de '{cadena3}': '{cadena3.TrimStart()}'"); // TrimStart
Console.WriteLine($"TrimEnd de '{cadena3}': '{cadena3.TrimEnd()}'"); // TrimEnd
Console.WriteLine($"Cadena a string: '{cadena1.ToString()}'"); // ToString

// IsNullOrEmpty y IsNullOrWhiteSpace
Console.WriteLine($"¿cadenaVacia es nula o vacía? {string.IsNullOrEmpty(cadenaVacia)}"); // IsNullOrEmpty
Console.WriteLine($"¿cadena3 es nula o vacía o solo espacios? {string.IsNullOrWhiteSpace(cadena3)}"); // IsNullOrWhiteSpace