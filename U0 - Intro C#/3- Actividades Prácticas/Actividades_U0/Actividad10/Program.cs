/* Enunciado:
             * 10)	Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar
             * (efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el número de 
             * cuenta (inventado). Darle las gracias por la compra al terminar o informarle que hubo
             * un error en la transacción y que debe revisar los datos ingresados.
             */

Console.WriteLine("Ingrese el valor del producto");
double precio = Convert.ToDouble(Console.ReadLine());
Console.Clear();
Console.WriteLine("ingrese la opcion de pago: \n" +
    "a - Efectivo\n" +
    "b - Tarjeta");
string opcionPago = Console.ReadLine();
switch (opcionPago)
{
    case "a":
        Console.WriteLine("Gracias por su compra!!");
        break;
    case "b":
        Console.WriteLine("Ingrese el numero de cuenta");
        Int64 numCuenta = 0;
        if (!Int64.TryParse(Console.ReadLine(), out numCuenta))
        {
            Console.WriteLine("Hubo un error con los datos ingresados");
            break;
        }
        Console.WriteLine("Gracias por su compra!!");
        break;
    default:
        Console.WriteLine("La opcion de pago no existe");
        break;
}
Console.ReadKey();