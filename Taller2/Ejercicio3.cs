using System;

namespace Taller2
{
    internal static class Ejercicio3
    {

        public static void Run()
        {
            try
            {
                Console.WriteLine("ingrese uno de los lados del cubo");
                double longitud = double.Parse(Console.ReadLine());
                double vol = VolumenCubo(longitud);
                Console.WriteLine("El volumen del cubo es de: " + vol + " centimetros cubicos");
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(ex.StackTrace);
            }
        }

        static double VolumenCubo(double longitud)
        {
            return Math.Pow(longitud, 3);
        }
    }
}