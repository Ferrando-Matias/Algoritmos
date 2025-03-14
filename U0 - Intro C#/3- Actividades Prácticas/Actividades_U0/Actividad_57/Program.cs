/* Enunciado:
             * 57)	Crear un método que nos salude, pasándole un nombre por parámetro
             */
Saludo("Matias");
Console.ReadKey();


void Saludo(string nombre)
{
    Console.WriteLine($"Buenos dias {nombre}");
}