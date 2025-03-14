/* Enunciado:
            * 8)	Pedir el nombre del día al usuario y decirle si es fin de semana o no. 
            * En caso de error, indicarlo. 
            */

Console.WriteLine("Ingrese el dia actual");
string dia = Console.ReadLine();
switch (dia.ToLower())
{
    case "lunes":
    case "martes":
    case "miercoles":
    case "jueves":
    case "viernes":
        Console.WriteLine("Es un dia de semana");
        break;
    case "sabado":
    case "domingo":
        Console.WriteLine("Es fin de semana");
        break;
    default:
        Console.WriteLine("El dia ingresado no es valido");
        break;
}
Console.ReadKey();