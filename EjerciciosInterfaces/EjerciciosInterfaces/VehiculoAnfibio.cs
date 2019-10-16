using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosInterfaces
{
    class VehiculoAnfibio:Vehiculo,IVehiculoTerrestre,IVehiculoAcuatico
    {
        public int MetrosSumergible { get; set; }

        public VehiculoAnfibio(int metrosSumergible, string marca, string modelo):base(marca, modelo)
        {
            MetrosSumergible = metrosSumergible;
        }

        public void SubirCuesta()
        {
            Console.WriteLine("Sube una cuesta");
        }

        public void Flotar()
        {
            Console.WriteLine("Esta flotando");
        }
    }
}
