using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Program : Ejercicio1
    {
        static void Main(string[] args)
        {
            int res;
            Console.WriteLine("Ingrese el numero de ejercicio que desea ejecutar \n");
            Console.WriteLine("ejercicio # 1");
            Console.WriteLine("ejercicio # 2");
            Console.WriteLine("ejercicio # 3");
            Console.WriteLine("ejercicio # 4");
            Console.WriteLine("ejercicio # 5");
            res = Int32.Parse(Console.ReadLine());
            switch (res)
            {
                case 1:
                    Ejercicio1.Run();
                    break;
                case 2:
                    Ejercicio2.Run();
                    break;
                case 3:
                    Ejercicio3.Run();
                    break;
                case 4:
                    Ejercicio4.Run();
                    break;
                case 5:
                    Ejercicio5.Run();
                    break;
                default:
                    Console.WriteLine("Número ingresado no válido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
