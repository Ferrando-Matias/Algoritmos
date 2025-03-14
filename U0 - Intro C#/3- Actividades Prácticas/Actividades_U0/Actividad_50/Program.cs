/* Enunciado:
             * 50)	Pedir al usuario que ingrese dos listas de números 
             * enteros y luego unir las dos listas en una sola.
             */
Console.WriteLine("Ingresa la primera lista de números enteros separados por comas:");
string input1 = Console.ReadLine();

Console.WriteLine("Ingresa la segunda lista de números enteros separados por comas:");
string input2 = Console.ReadLine();

// Separar los números ingresados por comas y convertirlos en dos listas de enteros
List<int> lista1 = new List<int>(Array.ConvertAll(input1.Split(','), int.Parse));
List<int> lista2 = new List<int>(Array.ConvertAll(input2.Split(','), int.Parse));

// Unir las dos listas en una sola
foreach (int numero in lista2)
{
    lista1.Add(numero);
}

// Mostrar la lista unida
Console.WriteLine("Lista unida:");
foreach (int numero in lista1)
{
    Console.WriteLine(numero);
}
Console.ReadKey();