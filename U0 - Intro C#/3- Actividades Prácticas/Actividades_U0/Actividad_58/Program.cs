/* Enunciado:
             * 58)	Crear un método que salude de manera personalizada. Si el usuario ingresa solo su nombre, el saludo debe ser simple. Si ingresa nombre y apellido, el saludo debe ser más formal, sin usar sobrecarga de métodos.
             */
Saludar("Matías");
Saludar("Matías Ferrando");
Console.ReadKey();


void Saludar(string nombreCompleto)
{
    // Verificamos si el string contiene un espacio
    if (nombreCompleto.Contains(" "))
    {
        Console.WriteLine($"¡Hola, {nombreCompleto}!");
    }
    else
    {
        Console.WriteLine($"Buenas tardes, {nombreCompleto}!");
    }
}