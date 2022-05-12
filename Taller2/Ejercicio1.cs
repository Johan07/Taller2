using System;

namespace Taller2
{
    internal class Ejercicio1
    {

        public static void Run()
        {
            Console.WriteLine("Ingrese el tiempo en horas");
            int hora = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tiempo en minutos");
            int minuto = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tiempo en segundos");
            int segundo = Int32.Parse(Console.ReadLine());
            int totalSegundos = EnSegundos(hora, minuto, segundo);
            Console.WriteLine("el total de segundos es: " + totalSegundos);
        }
        static int EnSegundos(int hora, int minuto, int segundo)
        {
            int horaSeg, minSeg, totalSeg;
            horaSeg = hora * 3600;
            minSeg = minuto * 60;
            totalSeg = horaSeg + minSeg + segundo;
            return totalSeg;
        }
    }
}