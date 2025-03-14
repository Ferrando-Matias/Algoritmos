using Actividad_55;

List<Participantes> participantes = new List<Participantes>();
do
{
    Console.WriteLine("Ingrese el nombre del participante o 'fin´ para terminar");
    string nombre = Console.ReadLine();
    if (nombre.ToLower() == "fin") break;
    Console.WriteLine("Ingrese los minutos que tardo en completar la carrera");
    int tiempo = 0;
    if (!int.TryParse(Console.ReadLine(), out tiempo))
    {
        Console.WriteLine("El tiempo ingresado no es correcto, ingrese al participante nuevamente");
        continue;
    }
    participantes.Add(new Participantes()
    {
        Nombre = nombre,
        Tiempo = tiempo
    });
    Console.Clear();
} while (true);

if (participantes.Count() == 0)
{
    Console.WriteLine("No se cargaron datos");
    Console.ReadKey();
    return;
}
List<Participantes> ListaOrdenada = participantes.OrderBy(x => x.Tiempo).ToList();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Puesto N°: {i + 1}");
    Console.WriteLine($"Participante: {ListaOrdenada[i].Nombre}");
    Console.WriteLine($"Tiempo: {ListaOrdenada[i].Tiempo}");
    Console.WriteLine("--------------------------------------");
}
Console.ReadKey();


