using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ConsoleApp85
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double[] temperaturas = new double[15];
            do
            {
                Console.WriteLine("0-Salir");
                Console.WriteLine("1-Ingresar Temperaturas");
                Console.WriteLine("2-Listar Velocidades");
                Console.WriteLine("3-Estadísticas");
                Console.WriteLine("4-Listado con Asteriscos");
                IngresarOpcionMenu(ref opcion);
                switch (opcion)
                {
                    case 0:
                        break;
                    case 1:
                        IngresoDeTemperatuas(temperaturas);
                        break;
                    case 2:
                        ListarTemperaturas(temperaturas);
                        break;
                    default:
                        break;
                }
            } while (true);
        }

        private static void ListarTemperaturas(double[] temp)
        {
            Console.Clear();
            Console.WriteLine("Listado de Temperaturas");
            foreach (var velocidad in temp)
            {
                Console.WriteLine(velocidad.ToString().PadLeft(4,' '));
            }
            Console.WriteLine("Generación finalizada");
            Console.ReadLine();

        }

        private static void IngresoDeTemperatuas(double[] temp)
        {
            Random r = new Random();
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = ObtenerTemperatura(r);
            }
            PresioneTecla();
        }

        private static void PresioneTecla()
        {
            Console.Clear();
            Console.WriteLine("Generación finalizada");
            Console.ReadLine();
        }

        private static double ObtenerTemperatura(Random random)
        {
            return double.Parse($"{random.Next(0, 24)},{random.Next(0, 9)}");
        }

        private static void IngresarOpcionMenu(ref int opcion)
        {
           
            do
            {
                
                Console.Write("Ingrese una opción:");
                if (!int.TryParse(Console.ReadLine(),out opcion))
                {
                    Console.WriteLine("Opción mal ingresada");
                    
                }else if (opcion<0 || opcion>4)
                {
                    Console.WriteLine("Opción fuera de rango [0-4]");
                }
                else
                {
                    break;
                }
            } while (true);
        }
    }
}
