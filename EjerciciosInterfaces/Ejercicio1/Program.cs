using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sanitario> personal = new List<Sanitario>()
            {
                new Medico("General",21,"12334999D","Pedro",1250,47),
                new Medico("Ginecologia",37,"12349537G","Manuela",1780,57),
                new Enfermero(0,"11223566S","Marcos",1030,21),
                new Enfermero(1,"4599222R","Luciana",1750,68),
                new Enfermero(1,"23550777F","Rebeca",1400,32),
                
            };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n- MOSTRAR DATOS -");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Sanitario sanitario in personal)
            {
                sanitario.Mostrar();
            }
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- SUBIRLES EL SUELDO UN 1% -");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------");

            foreach (Sanitario sanitario in personal)
            {
                sanitario.SueldoBase = sanitario.SueldoBase + (sanitario.SueldoBase / 100);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n- MOSTRAR DATOS -");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Sanitario sanitario in personal)
            {
                sanitario.Mostrar();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n- QUIEN SE PUEDE JUBILAR -");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Sanitario sanitario in personal)
            {
                if (sanitario.Jubilarse())
                {
                    sanitario.Mostrar();
                }
                
            }

        }
    }
}
