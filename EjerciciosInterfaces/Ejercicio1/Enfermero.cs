using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Enfermero:Sanitario
    {
        public int Puesto { get; set; }

        public Enfermero(int puesto, string dni, string nombre, double sueldoBase, int edad):base(dni,nombre,sueldoBase,edad)
        {
            Puesto = puesto;
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.Write($"Puesto: {Puesto}\nSueldo: {CalcularSueldo()}\n");
        }
        public override double CalcularSueldo()
        {
            if (Puesto == 1)
            {
                return SueldoBase + 200;
            }
            return SueldoBase;

            
        }
    }
}
