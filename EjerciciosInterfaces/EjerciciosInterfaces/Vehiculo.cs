using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosInterfaces
{
    class Vehiculo: IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public void Arrancar()
        {
            Console.WriteLine("Ha arrancado");
        }

        public void Frenar()
        {
            Console.WriteLine("Ha frenado");
            
        }

        public void Aparcar()
        {
            Console.WriteLine("Ha aparcado");
            
        }

        public void Acelerar(int cuanto)
        {
            Console.WriteLine($"Ha acelerado {cuanto}Km/h");
        }
    }
}
