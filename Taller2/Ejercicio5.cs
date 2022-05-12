using System;

namespace Taller2
{
    internal static class Ejercicio5
    {

        public static void Run()
        {
            Encuesta();
        }

        static void Encuesta()
        {
            try
            {
                int sumaEdad = 0;
                Console.WriteLine("Ingrese la cantidad de personas a promediar la edad del conjunto");
                int personas = int.Parse(Console.ReadLine());
                for (int i = 1; i <= personas; i++)
                {
                    Console.WriteLine("Ingrese la edad de la persona # " + i);
                    sumaEdad += Int32.Parse(Console.ReadLine());
                }
                decimal promedio = sumaEdad / personas;
                Console.WriteLine("el promedio de edades de las personas del conjunto es: " + promedio);
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