/* Enunciado:
             * 51)	Pedir al usuario que ingrese dos listas de números
             * enteros y luego encontrar los elementos que están en 
             * ambas listas.
             */
Console.WriteLine("Ingresa la primera lista de números enteros separados por comas:");
string input1 = Console.ReadLine();

Console.WriteLine("Ingresa la segunda lista de números enteros separados por comas:");
string input2 = Console.ReadLine();

// Separar los números ingresados por comas y convertirlos en dos listas de enteros
List<int> lista1 = new List<int>(Array.ConvertAll(input1.Split(','), int.Parse));
List<int> lista2 = new List<int>(Array.ConvertAll(input2.Split(','), int.Parse));

// Encontrar los elementos que están en ambas listas
List<int> elementosComunes = new List<int>();

foreach (int numero1 in lista1)
{
    foreach (int numero2 in lista2)
    {
        if (numero1 == numero2)
        {
            elementosComunes.Add(numero1);
            break;
        }
    }
}
for (int i = 0; i < elementosComunes.Count; i++)
{
    int elementoActual = elementosComunes[i];
    for (int j = i + 1; j < elementosComunes.Count; j++)
    {
        if (elementosComunes[j] == elementoActual)
        {
            elementosComunes.RemoveAt(j);
            j--;
        }
    }
}

// Mostrar los elementos comunes encontrados
Console.WriteLine("Elementos comunes encontrados en ambas listas:");
foreach (int numero in elementosComunes)
{
    Console.WriteLine(numero);
}
Console.ReadKey();