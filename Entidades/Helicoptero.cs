using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Helicoptero:VehiculoAereo
    {
        public int Helices { get; set; }
        public bool Misiles  { get; set; }

        public Helicoptero() { }
        public Helicoptero(string modelo, decimal velmax, string motor, int alas, int turbinas, string combustible, int helices, bool misiles) : base(modelo, velmax, motor, alas, turbinas, combustible)
        {
            this.Helices = helices;
            this.Misiles = misiles;
        }

    }
}
