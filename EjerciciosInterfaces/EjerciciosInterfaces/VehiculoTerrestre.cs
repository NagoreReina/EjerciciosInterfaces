using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosInterfaces
{
    class VehiculoTerrestre: Vehiculo, IVehiculoTerrestre
    {
        public int Caballos { get; set; }

        public VehiculoTerrestre(int caballos, string marca, string modelo) : base(marca, modelo)
        {
            Caballos = caballos;
        }

        public void SubirCuesta()
        {
            Console.WriteLine("Sube una cuesta");
        }
    }
}
