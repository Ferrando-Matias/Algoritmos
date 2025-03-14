/* Enunciado:
            * 48)	Pedir al usuario que ingrese una lista de números enteros
            * y luego contar cuántos elementos sin repetir hay en la lista.
            */
Console.WriteLine("Ingresa una lista de números enteros separados por comas:");
string input = Console.ReadLine();

// Separar los números ingresados por comas y convertirlos en una lista de enteros
List<int> lista = new List<int>(Array.ConvertAll(input.Split(','), int.Parse));

// Contar los elementos únicos en la lista
int conteoElementosUnicos = 0;

// Manera 1
//List<int> listaUnicos = lista.ToList();

//for (int i = 0; i < lista.Count; i++)
//{
//    for (int j = i + 1; j < lista.Count; j++)
//    {
//        if (lista[i] == lista[j])
//        {
//            listaUnicos.RemoveAll(x => x == lista[i]);
//        }
//    }
//}


// Manera 2
//int contUnicos = 0;
//for (int i = 0; i < lista.Count; i++)
//{
//    int contador = 0;
//    for (int j = 0; j < lista.Count; j++)
//    {
//        int a = lista[i];
//        int b = lista[j];
//        if (a == b)
//        {
//            contador++;
//        }
//    }

//    if (contador == 1)
//    {
//        contUnicos++;
//    }
//}

//Manera 3
for (int i = 0; i < lista.Count; i++)
{
    bool esUnico = true;

    for (int j = 0; j < lista.Count; j++)
    {
        if (j == i) continue;

        if (lista[i] == lista[j])
        {
            esUnico = false;
            break;
        }
    }

    if (esUnico) conteoElementosUnicos++;
}


// Mostrar el conteo de elementos únicos
Console.WriteLine("Cantidad de elementos únicos: " + conteoElementosUnicos);

Console.ReadKey();