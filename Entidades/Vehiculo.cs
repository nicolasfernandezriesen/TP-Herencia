using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        public string Modelo { get; set; }
        public decimal VelMax { get; set; }
        public string Motor { get; set; }


        public Vehiculo() { }

        public Vehiculo(string modelo, decimal velMax, string motor)
        {
            Modelo = modelo;
            VelMax = velMax;
            Motor = motor;
        }
    }

}
