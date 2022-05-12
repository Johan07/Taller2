using System;

namespace Taller2
{
    internal static class Ejercicio4
    {
        public static void Run()
        {
            PositivoNegativo();
        }
        static void PositivoNegativo()
        {
            try
            {
                Console.WriteLine("Por favor ingrese un número para saber si es positivo o negativo");
                int numIngresado = Int32.Parse(Console.ReadLine());
                if (numIngresado >= 0)
                {
                    Console.WriteLine("El número " + numIngresado + " es positivo");
                }
                else
                {
                    Console.WriteLine("El número " + numIngresado + " es negativo");
                }

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
    }
}