using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validando número par y impar"); 
            // Solicitar un valor de entrada al usuario
            Console.WriteLine("Ingrese un número entero:"); 
            int numero; 
            // Validar entrada
            if (!int.TryParse(Console.ReadLine(), out numero)) { 
                Console.WriteLine("Entrada inválida. Debe ingresar un número entero."); 
                return; 
            } 
            //----------
            // Estructura condicional doble para evaluar par o impar
            if (numero % 2 == 0) // % devuelve el residuo de una división entera
            { 
                Console.WriteLine($"El número {numero} es par.");//envía este mensaje en caso de cumplirse la condición
            } else { 
                Console.WriteLine($"El número {numero} es impar.");//envía este mensaje en caso de no cumplirse la condición
            }
        }
    }
}
