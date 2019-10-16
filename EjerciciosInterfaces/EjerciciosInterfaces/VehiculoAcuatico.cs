using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosInterfaces
{
    class VehiculoAcuatico: Vehiculo, IVehiculoAcuatico
    {
        public int Eslora { get; set; }

        public VehiculoAcuatico(int eslora, string marca, string modelo): base(marca, modelo)
        {
            Eslora = eslora;
        }

        public void Flotar()
        {
            Console.WriteLine("Esta flotando");
        }
    }
}
