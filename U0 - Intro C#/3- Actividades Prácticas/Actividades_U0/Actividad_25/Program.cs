// Enunciado: Realizar un temporizador
Console.WriteLine("Ingrese las horas");
int horas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese los minutos");
int minutos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese los segundos");
int segundos = Convert.ToInt32(Console.ReadLine());

while (horas >= 0)
{
    while (minutos >= 0)
    {
        while (segundos >= 0)
        {
            Console.Clear();
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", horas, minutos, segundos);
            Thread.Sleep(1000); // Espera 1 segundo
            segundos--;
        }
        segundos = 59;
        minutos--;
    }
    minutos = 59;
    horas--;
}
Console.Clear();
Console.WriteLine("Fin");
Console.ReadKey();