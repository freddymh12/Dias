using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número del 1 al 7:");
            if (int.TryParse(Console.ReadLine(), out int numeroDia))
            {
                string nombreDia = ObtenerNombreDia(numeroDia);
                Console.WriteLine($"El día correspondiente al número {numeroDia} es: {nombreDia}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido del 1 al 7.");
                Console.ReadKey();
            }
        }

        static string ObtenerNombreDia(int numeroDia)
        {
            switch (numeroDia)
            {
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miércoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sábado";
                case 7:
                    return "Domingo";
                default:
                    return "Número de día no válido";
            }
        }
    }
    }
