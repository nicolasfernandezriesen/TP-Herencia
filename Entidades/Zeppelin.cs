using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Zeppelin:VehiculoAereo
    {
        public decimal AlturaMax { get; set; }
        public bool Publicidad { get; set; }

        public Zeppelin() { }
        public Zeppelin(string modelo, decimal velmax, string motor, int alas, int turbinas, string combustible, decimal alturamax, bool publicidad) : base(modelo, velmax, motor, alas, turbinas, combustible)
        {
            this.AlturaMax = alturamax;
            this.Publicidad = publicidad;
        }
    }
}
