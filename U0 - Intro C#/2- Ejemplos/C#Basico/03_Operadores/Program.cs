using System;

// **Operadores aritméticos**
int a = 10;      // Variable entera a
int b = 5;       // Variable entera b
int resultado;    // Variable para almacenar resultados

Console.WriteLine($"Valor A: {a}");
Console.WriteLine($"Valor B: {b}");
Console.WriteLine("---------------------------------");

resultado = a + b; // Suma
Console.WriteLine($"Suma: {resultado}"); // Muestra el resultado de la suma

resultado = a - b; // Resta
Console.WriteLine($"Resta: {resultado}"); // Muestra el resultado de la resta

resultado = a * b; // Multiplicación
Console.WriteLine($"Multiplicación: {resultado}"); // Muestra el resultado de la multiplicación

resultado = a / b; // División
Console.WriteLine($"División: {resultado}"); // Muestra el resultado de la división

resultado = a % b; // Módulo (resto de la división)
Console.WriteLine($"Módulo: {resultado}"); // Muestra el resultado del módulo

Console.WriteLine("---------------------------------");

// **Operadores de asignación**
int c = 20; // Asignación simple
Console.WriteLine();
Console.WriteLine($"Valor C: {c}");
Console.WriteLine();

c += 10; // Equivale a c = c + 10
Console.WriteLine($"Asignación (c += 10): {c}"); // Muestra el valor de c después de la asignación

c -= 5; // Equivale a c = c - 5
Console.WriteLine($"Asignación (c -= 5): {c}"); // Muestra el valor de c después de la asignación

c *= 2; // Equivale a c = c * 2
Console.WriteLine($"Asignación (c *= 2): {c}"); // Muestra el valor de c después de la asignación

c /= 4; // Equivale a c = c / 4
Console.WriteLine($"Asignación (c /= 4): {c}"); // Muestra el valor de c después de la asignación

c %= 3; // Equivale a c = c % 3
Console.WriteLine($"Asignación (c %= 3): {c}"); // Muestra el valor de c después de la asignación

Console.WriteLine("---------------------------------");

// **Operadores lógicos**
bool x = true;  // Variable booleana x
bool y = false; // Variable booleana y

Console.WriteLine();
Console.WriteLine($"Valor logico x: {x}");
Console.WriteLine($"Valor logico y: {y}");
Console.WriteLine();

bool resultadoLogico = x && y; // AND lógico
Console.WriteLine($"AND lógico (x && y): {resultadoLogico}"); // Muestra el resultado de AND

resultadoLogico = x || y; // OR lógico
Console.WriteLine($"OR lógico (x || y): {resultadoLogico}"); // Muestra el resultado de OR

resultadoLogico = !x; // NOT lógico
Console.WriteLine($"NOT lógico (!x): {resultadoLogico}"); // Muestra el resultado de NOT

// **Operadores relacionales (o de comparación)**

bool esMayor = a > b; // Mayor que
Console.WriteLine($"a es mayor que b: {esMayor}"); // Muestra si a es mayor que b

bool esMenor = a < b; // Menor que
Console.WriteLine($"a es menor que b: {esMenor}"); // Muestra si a es menor que b

bool esIgual = a == b; // Igual que
Console.WriteLine($"a es igual a b: {esIgual}"); // Muestra si a es igual a b

bool esDistinto = a != b; // Distinto de
Console.WriteLine($"a es distinto de b: {esDistinto}"); // Muestra si a es distinto de b

bool esMayorOIgual = a >= b; // Mayor o igual que
Console.WriteLine($"a es mayor o igual que b: {esMayorOIgual}"); // Muestra si a es mayor o igual que b

bool esMenorOIgual = a <= b; // Menor o igual que
Console.WriteLine($"a es menor o igual que b: {esMenorOIgual}"); // Muestra si a es menor o igual que b
Console.WriteLine("---------------------------------");

// **Operadores de incremento y decremento**
Console.WriteLine($"Valor actual de a: {a}");

a++; // Incremento a += 1;
Console.WriteLine($"Incremento (a++): {a}"); // Muestra el valor de a después del incremento

Console.WriteLine($"Valor actual de b: {b}");
b--; // Decremento
Console.WriteLine($"Decremento (b--): {b}"); // Muestra el valor de b después del decremento

// Incremento y decremento previo
Console.WriteLine($"Valor actual de a: {a}");
int d = a++; 
Console.WriteLine($"a: {a}, d = a++: {d}"); 

Console.WriteLine($"Valor actual de a: {a}");
int e = ++a; 
Console.WriteLine($"a: {a}, e = ++a: {e}"); 
