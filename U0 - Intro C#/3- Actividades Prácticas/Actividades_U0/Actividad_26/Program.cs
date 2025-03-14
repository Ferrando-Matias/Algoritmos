/* Enunciado:
            * 26)	Pedirle al usuario una serie de edades (como mínimo 10) 
            * e informar y clasificar, según corresponda, la cantidad de 
            * edades de cada categoría: 0 -8: Infantil; 9 -14: Cadete; 
            * 15 -20: Juvenil; >20: Vitalicio. La carga de datos finalizará
            * al escribir la palabra “fin”. 
            */
int cantMin = 0, infantil = 0, cadete = 0, juvenil = 0, vitalicio = 0;
do
{
    Console.Clear();
    Console.WriteLine("Ingrese una edad o fin");
    string respuesta = Console.ReadLine();
    if (respuesta == "fin")
    {
        if (cantMin >= 10)
        {
            break;
        }
        else
        {
            Console.WriteLine($"Debe haber como minimo 10 edades ingresadas, faltan {10 - cantMin}. Presione enter para continuar");
            Console.ReadKey();
            continue;
        }
    }
    int num = Convert.ToInt32(respuesta);
    cantMin++;
    if (num >= 0 && num <= 8)
    {
        infantil++;
    }
    else if (num >= 9 && num <= 14)
    {
        cadete++;
    }
    else if (num >= 15 && num <= 20)
    {
        juvenil++;
    }
    else
    {
        vitalicio++;
    }
} while (true);
Console.WriteLine("Infantiles: {0} \n" +
                    "Cadetes: {1} \n" +
                    "Juveniles: {2} \n" +
                    "Vitalicios: {3}", infantil, cadete, juvenil, vitalicio);
Console.ReadKey();