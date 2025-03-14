
// Condicionales:

// Condicional simple: If - Else

int edad = 10;

if (!(edad < 0)) Console.WriteLine("La edad es correcta"); // solo con una unica instruccion

if (edad < 0 || edad > 150)
{
    Console.WriteLine("La edad es incorrecta");
    // mas instrucciones
}
else if (edad >= 0 && edad <= 18)
{
    Console.WriteLine("Es menor de edad");
}
else
{
    Console.WriteLine("Es mayor de edad");
}

//  (CONDICION) ? PARTE VERDADERA : PARTE FALSA ; Operador Ternario
string resultado = (edad >= 0 && edad <= 18) ? "Es menor de edad" : "Es mayor de edad";
Console.WriteLine(resultado);

// Condicional multiple: Switch

string nombreDia = "Sabado";

if (nombreDia == "Lunes" || nombreDia == "Martes" || nombreDia == "Miercoles" || nombreDia == "Jueves" || nombreDia == "Viernes")
{
    Console.WriteLine($"{nombreDia} es un dia de semana");
}
else if (nombreDia == "Sabado" || nombreDia == "Domingo")
{
    Console.WriteLine($"{nombreDia} es fin de semana");
}
else
{
    Console.WriteLine($"{nombreDia} No es un dia correcto");
}

switch (nombreDia)
{
    case "Lunes":
    case "Martes":
    case "Miercoles":
    case "Jueves":
    case "Viernes":
        Console.WriteLine("Dia de semana");
        //mas instrucciones
        break;
    case "Sabado":
    case "Domingo":
        Console.WriteLine("Fin de semana");
        //mas instrucciones
        break;
    default:
        Console.WriteLine("Dia incorrecto");
        break;
}

char letra = 'a';
switch (letra)
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("Es Vocal");
        break;
    default:
        Console.WriteLine("Es consonante");
        break;
}

int dia = 3;
switch (dia) // Switch simple
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miércoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sabado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Dia incorrecto");
        break;
}

// **Switch con expresión**
string diaNombre = dia switch // Switch como expresión
{
    1 => "Lunes",
    2 => "Martes",
    3 => "Miércoles",
    4 => "Jueves",
    5 => "Viernes",
    6 => "Sabado",
    7 => "Domingo",
    _ => "Dia incorrecto" // Caso por defecto
};
Console.WriteLine(diaNombre); // Muestra el nombre del día

// **Diferencia entre If y Switch**
// 'if' se usa para condiciones complejas y múltiples, mientras que 'switch' se usa para evaluar una sola expresión contra múltiples valores.

// Ambito de variables
int x = 10; // variable global o de clase
if (true)
{
    int y = 20; // variable local, solo va a ser accesible dentro del if
    Console.WriteLine($"x: {x}, y: {y}"); // Muestra ambas variables
    Console.WriteLine(y);
}

// Console.WriteLine(y); // Esto causaría un error, ya que y no está accesible fuera del if
