/* Enunciado:
             * 52)	Pedir al usuario que ingrese dos listas de números 
             * enteros y luego encontrar los elementos que están en la 
             * primera lista, pero no en la segunda.
             */
Console.WriteLine("Ingresa la primera lista de números enteros separados por comas:");
string input1 = Console.ReadLine();

Console.WriteLine("Ingresa la segunda lista de números enteros separados por comas:");
string input2 = Console.ReadLine();

// Separar los números ingresados por comas y convertirlos en dos listas de enteros
List<int> lista1 = new List<int>(Array.ConvertAll(input1.Split(','), int.Parse));
List<int> lista2 = new List<int>(Array.ConvertAll(input2.Split(','), int.Parse));

// Encontrar los elementos que están en la primera lista pero no en la segunda
List<int> elementosExclusivos = new List<int>();

foreach (int numero in lista1)
{
    bool encontrado = false;

    foreach (int num in lista2)
    {
        if (numero == num)
        {
            encontrado = true;
            break;
        }
    }

    if (!encontrado)
    {
        elementosExclusivos.Add(numero);
    }
}

// Mostrar los elementos exclusivos encontrados
Console.WriteLine("Elementos exclusivos encontrados en la primera lista:");
foreach (int numero in elementosExclusivos)
{
    Console.WriteLine(numero);
}
Console.ReadKey();