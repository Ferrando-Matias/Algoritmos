using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Clases_Metodos
{
    internal class Accessors
    {
        #region Atributos
        private int edad;
        #endregion

        #region Metodos

        // Metodo Setter (recibe valores y no devuelve nada)
        public void SetEdad(int edad)
        {
            if (edad >= 0 && edad < 200)
            {
                this.edad = edad;   // Si la edad esta comprendida entre los valores 0 y 200 la guarda en el atributo edad de la clase (usando el "this")
            }
        }

        // Metodo Getter (devuelve un valor)
        public int GetEdad()
        {
            return this.edad;   // Retorna el valor contenido en el atributo edad perteneciente a la clase
        }


        // Property
        public int Edad
        {
            get
            {
                return this.edad;   // Retorna el valor contenido en el atributo edad perteneciente a la clase
            }
            set
            {
                // Si el valor recibido esta comprendido entre 0 y 200 la guarda en el atributo edad de la clase
                if (value >= 0 && value < 200)
                {
                    this.edad = value;
                }
            }
        }

        // Otra manera mas simplificada seria utilizando expresiones Lambdas
        public int EdadLambda
        {
            get => this.edad;   // Uso de expresión Lambda

            set
            {
                // Dado que el if contenia solo una instruccion dentro se puede escribir en una sola linea
                if (value >= 0 && value < 200) this.edad = value; 
            }            
        }
        #endregion
    }
}
