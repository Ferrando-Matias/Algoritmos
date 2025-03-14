using Actividad_56;

string Nombre = "";
double Monto;

List<Vendedor> VList = new List<Vendedor>();
List<totales> LTotales = new List<totales>();


//CARGA DE DATOS EN LA PRIMERA LISTA
do
{
    Console.WriteLine("Ingrese el NOMBRE del vendedor");
    Nombre = Console.ReadLine().ToUpper();
    if (Nombre == "") break;

    Console.WriteLine("Ingrese el MONTO VENDIDO");
    Monto = Convert.ToDouble(Console.ReadLine());

    VList.Add(new Vendedor()
    {
        Nombre = Nombre,
        Monto = Monto
    });

    Console.Clear();

} while (Nombre != "");

//MUESTRO LA LISTA CARGADA SIN AGRUPAR
for (int i = 0; i < VList.Count; i++)
{
    Console.WriteLine(VList[i].Nombre + "|" + VList[i].Monto + "|");
}

//RECORRO LA PRIMERA LISTA Y AGRUPO POR VENDEDOR EN UNA SEGUNDA LISTA
bool encontrado = false;
for (int i = 0; i < VList.Count; i++)
{
    if (LTotales.Count == 0)
    {
        LTotales.Add(new totales()
        {
            Nombre = VList[i].Nombre,
            Monto = VList[i].Monto
        });
    }
    else
    {
        for (int x = 0; x < LTotales.Count; x++)
        {
            encontrado = false;
            if (VList[i].Nombre == LTotales[x].Nombre)
            {
                LTotales[x].Monto += VList[i].Monto;
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
        {
            LTotales.Add(new totales()
            {
                Nombre = VList[i].Nombre,
                Monto = VList[i].Monto
            });
        }
    }
}


//MUESTRO LA SEGUNDA LISTA AGRUPADA
Console.WriteLine(" ");
Console.WriteLine("==============================");
Console.WriteLine(" ");

for (int i = 0; i < LTotales.Count; i++)
{
    Console.WriteLine(LTotales[i].Nombre + "|" + LTotales[i].Monto + "|");
}

Console.WriteLine(" ");
Console.WriteLine("==============================");
Console.WriteLine(" ");

//ORDENO LA LISTA DE MANERA DESCENDENTE POR EL MONTO
List<totales> TotalesOrdenados = LTotales.OrderByDescending(Totales => Totales.Monto).ToList();
foreach (totales Vededor in TotalesOrdenados)
    Console.WriteLine(Vededor.Nombre + ": " + Vededor.Monto);


Console.ReadKey();