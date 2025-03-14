/* Enunciado: 
             * 15)	Dadas las 3 notas obtenidas por un alumno, calcular e informar 
             * por pantalla su promedio e informar una leyenda que indique si está 
             * aprobado o no. La condición de aprobación es obtener un promedio
             * mayor o igual que 4.
             */

Console.WriteLine("Ingrese la primer nota");


int nota1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la segunda nota");
int nota2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la tercer nota");
int nota3 = Convert.ToInt32(Console.ReadLine());
int promedio = 0;
//if (nota1 > 0 && nota2 > 0 && nota3 > 0 && nota1 < 11 && nota2 < 11 && nota3 < 11)
//{
//    promedio = (nota1 + nota2 + nota3) / 3;
//    if (promedio >= 4)
//    {
//        Console.WriteLine("Esta aprobado");
//    }
//    else
//    {
//        Console.WriteLine("Esta desaprobado");
//    }
//}else
//{
//    Console.WriteLine("las notas deben ser mayores o iguales a 1 y menores o iguales a 10");
//}
if (!(nota1 > 0 && nota2 > 0 && nota3 > 0 && nota1 < 11 && nota2 < 11 && nota3 < 11))
{
    Console.WriteLine("las notas deben ser mayores o iguales a 1 y menores o iguales a 10");
    Console.ReadKey();
    return;
}
promedio = (nota1 + nota2 + nota3) / 3;
if (promedio >= 4)
{
    Console.WriteLine("Esta aprobado");
}
else
{
    Console.WriteLine("Esta desaprobado");
}
Console.ReadKey();