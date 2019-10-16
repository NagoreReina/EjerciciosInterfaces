using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Medico:Sanitario
    {
        public string Especialidad { get; set; }
        public int NumeroPacientes { get; set; }

        public Medico(string especialidad, int numeroPacientes, string dni, string nombre, double sueldoBase, int edad):base(dni,nombre,sueldoBase,edad)
        {
            Especialidad = especialidad;
            NumeroPacientes = numeroPacientes;
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.Write($"Especialidad: {Especialidad}\nNumero de Pacientes: {NumeroPacientes}\nSueldo: {CalcularSueldo()}\n");
        }
        public override double CalcularSueldo()
        {
            return SueldoBase + (1.20 * NumeroPacientes);
        }
    }
}
