/* Enunciado:
             * 5)	Calcular el número de pulsaciones que una persona debe tener por cada 10
             * segundos de ejercicio, si la fórmula es:	numPulsaciones = (220 - edad)/6
             * */

Console.WriteLine("Ingrese se edad");
double edad = Convert.ToDouble(Console.ReadLine());
double numPulsacionesMax = (220 - edad) / 6;
Console.WriteLine("El numero de pulsaciones maximas cada 10 segundos para " +
                    "usted es de: {0:N2} pulsaciones", numPulsacionesMax);
Console.ReadKey();