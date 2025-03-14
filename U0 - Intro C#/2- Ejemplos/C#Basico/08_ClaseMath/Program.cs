// Definimos algunos números para usar en los ejemplos
double numero1 = -9.5;
double numero2 = 3.7;
double numero3 = 2;
double numero4 = 8;

// Valor absoluto
double valorAbsoluto = Math.Abs(numero1);
Console.WriteLine($"Valor absoluto de {numero1}: {valorAbsoluto}"); // Salida: 9.5

// Ceil (techo)
double techo = Math.Ceiling(numero2);
Console.WriteLine($"Techo de {numero2}: {techo}"); // Salida: 4

// Floor (suelo)
double suelo = Math.Floor(numero2);
Console.WriteLine($"Suelo de {numero2}: {suelo}"); // Salida: 3

// Máximo
double maximo = Math.Max(numero1, numero2);
Console.WriteLine($"Máximo entre {numero1} y {numero2}: {maximo}"); // Salida: 3.7

// Mínimo
double minimo = Math.Min(numero1, numero2);
Console.WriteLine($"Mínimo entre {numero1} y {numero2}: {minimo}"); // Salida: -9.5

// Potencia
double potencia = Math.Pow(numero3, numero4); // 2^8
Console.WriteLine($"{numero3} elevado a la {numero4}: {potencia}"); // Salida: 256

// Raíz cuadrada
double raizCuadrada = Math.Sqrt(numero4);
Console.WriteLine($"Raíz cuadrada de {numero4}: {raizCuadrada}"); // Salida: 2.8284271247461903

// Redondeo
double redondeo = Math.Round(numero1);
Console.WriteLine($"Redondeo de {numero1}: {redondeo}"); // Salida: -10
