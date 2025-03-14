/* Enunciado:
             * 6)	En un hospital existen tres áreas: Ginecología, Pediatría y Traumatología. 
             * El presupuesto anual del hospital se reparte de la siguiente manera:
                    •	Área: Ginecología  -  Porcentaje del presupuesto:  40%
                    •	Área: Traumatología - Porcentaje del presupuesto :30%
                    •	Área: Pediatría - Porcentaje del presupuesto: 30%
            Mostrar al usuario la cantidad de dinero que recibirá cada área, 
            para cualquier monto presupuestal ingresado. 
             */

Console.WriteLine("Ingrese el presupuesto anual");
double presupuestoAnual = Convert.ToDouble(Console.ReadLine());
double presGineco = presupuestoAnual * 0.4;
double presTrauma = presupuestoAnual * 0.3;
double presPedi = presupuestoAnual * 0.3;
Console.WriteLine("El presupuesto de ${0} se dividirá de la siguiente manera: \n" +
                    "* Ginecologia: ${1} \n" +
                    "* Traumatologia: ${2} \n" +
                    "* Pediatria: ${3}",
                    presupuestoAnual, presGineco, presTrauma, presPedi);
Console.ReadKey();