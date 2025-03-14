/* Enunciado:
             * 29)	Se realiza una encuesta para estimar el grado de aceptación 
             * de los productos “Coca-Cola” y “Pepsi” en el mercado. A cada 
             * encuestado se le pregunta si consume Coca-Cola y si consume Pepsi.
             * La respuesta puede ser sí o no. Se pide calcular e informar el 
             * porcentaje de consumidores de:
                    a) Solo Coca-Cola
                    b) Solo Pepsi
                    c) Ambos productos
                    d) Ninguno de los productos
             */
int ambos = 0, ninguno = 0, soloCoca = 0, soloPepsi = 0, cantEncuestados = 0;
do
{
    Console.Clear();
    cantEncuestados++;
    Console.WriteLine($"Encuestado N°: {cantEncuestados}");
    Console.WriteLine("----------------------------------");
    Console.WriteLine("Responder solo con 'si', 'no' o 'fin':");
    Console.WriteLine("Consume Coca-Cola?");
    string respCoca = Console.ReadLine();
    if (respCoca.ToLower() == "fin")
    {
        cantEncuestados--;
        break;
    }
    Console.WriteLine("Consume Pepsi?");
    string respPepsi = Console.ReadLine();
    respCoca.ToLower();
    respPepsi.ToLower();
    if (respPepsi != "si" && respPepsi != "no" || respCoca != "si" && respCoca != "no")
    {
        Console.WriteLine("Respuesta Erronea - Presione enter para continuar");
        cantEncuestados--;
        Console.ReadKey();
        continue;
    }
    if (respCoca == "si")
    {
        if (respPepsi == "si")
        {
            ambos++;
        }
        else
        {
            soloCoca++;
        }
    }
    else
    {
        if (respPepsi == "si")
        {
            soloPepsi++;
        }
        else
        {
            ninguno++;
        }
    }

} while (true);

int porcSoloCoca = soloCoca * 100 / cantEncuestados;
int porcSoloPepsi = soloPepsi * 100 / cantEncuestados;
int porcAmbos = ambos * 100 / cantEncuestados;
int porcNinguno = ninguno * 100 / cantEncuestados;

Console.WriteLine("Los Porcentajes son: \n" +
    $"Ambos Productos: {porcAmbos}\n" +
    $"Ningun Producto: {porcNinguno}\n" +
    $"Solo Coca-Cola: {porcSoloCoca}\n" +
    $"Solo Pepsi: {porcSoloPepsi}");

Console.ReadKey();