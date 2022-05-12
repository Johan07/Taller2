using System;

namespace Taller2
{
    internal static class Ejercicio2
    {
        public static void Run()
        {
            Console.WriteLine("Ingrese el tiempo en segundos");
            int segundos = Int32.Parse(Console.ReadLine());
            SegundosAHMS(segundos);
        }
        static void SegundosAHMS(int segundos)
        {
            int totalhoras, totalmin, totalseg;
            totalhoras = segundos / 3600;
            totalmin = (segundos % 3600) / 60;
            totalseg = (segundos % 3600) % 60;
            Console.WriteLine("El tiempo total en horas es {0}, en minutos {1}, en segundos {2}", totalhoras, totalmin, totalseg);
        }
    }
}