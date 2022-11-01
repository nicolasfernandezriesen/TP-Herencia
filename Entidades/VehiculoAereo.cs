using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoAereo : Vehiculo
    {
        public int Alas { get; set; }
        public int Turbinas { get; set; }
        public string Combustible { get; set; }

        public VehiculoAereo() { }

        public VehiculoAereo(string modelo, decimal velmax, string motor,int alas, int turbinas, string combustible):base( modelo, velmax, motor)
        {
            Alas = alas;
            Turbinas = turbinas;
            Combustible = combustible;
        }
    }
}
