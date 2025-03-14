using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPOO
{
    internal class Empleado
    {
        private double Salario;
        private double EvaluaSalario(double Salario)
        {
            if(Salario < 0) return 0;
            else return Salario;
        }
        public double SALARIO
        {
            get
            {
                return this.Salario;
            }
            set
            {
                this.Salario = EvaluaSalario(value);
            }


            //También la sintaxis puede ser la siguiente:
            //get => this.Salario;
            //set => this.Salario = EvaluaSalario(value);
            
        }

    }
}
