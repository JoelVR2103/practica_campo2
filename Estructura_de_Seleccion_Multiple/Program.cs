using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_Seleccion_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Días de la semana-----"); 
            // Solicitar un valor de entrada al usuario
            Console.WriteLine("Ingrese un número del 1 al 7 para el día de la semana:"); 
            int dia; 
            // Validar entrada sea válida
            if (!int.TryParse(Console.ReadLine(), out dia)) { 
                Console.WriteLine("Entrada inválida. Debe ingresar un número entero."); 
                return; 
            } 
            // Estructura de selección múltiple
            switch (dia) { 
                case 1: Console.WriteLine("El día ingresado es Lunes"); 
                    break; 
                case 2: Console.WriteLine("El día ingresado es Martes"); 
                    break; 
                case 3: Console.WriteLine("El día ingresado es Miércoles"); 
                    break; 
                case 4: Console.WriteLine("El día ingresado es Jueves"); 
                    break; 
                case 5: Console.WriteLine("El día ingresado es Viernes"); 
                    break; 
                case 6: Console.WriteLine("El día ingresado es Sábado"); 
                    break; 
                case 7: Console.WriteLine("El día ingresado es Domingo"); 
                    break; 
                default: Console.WriteLine("Número inválido. Debe ser entre 1 y 7."); 
                    break; 
            }
        }
    }
}
