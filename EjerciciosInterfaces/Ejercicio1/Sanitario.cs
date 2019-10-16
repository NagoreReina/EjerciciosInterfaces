using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Sanitario:IPersonalLaboral
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public double SueldoBase { get; set; }
        public int Edad { get; set; }

        public Sanitario(string dni, string nombre, double sueldoBase, int edad)
        {
            Dni = dni;
            Nombre = nombre;
            SueldoBase = sueldoBase;
            Edad = edad;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"\n- DATOS -\nDNI: {Dni}\nNombre: {Nombre}\nEdad: {Edad}");
        }

        public bool Jubilarse()
        {
            if (Edad >= 65)
            {
                return true;
            }
            return false;
        }

        public virtual double CalcularSueldo()
        {
            return 0;
        }
    }
}
