using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion:VehiculoAereo
    {
        public int CantPasajeros { get; set; }
        public string Aerolinea { get; set; }

        public Avion() { }
        public Avion(string modelo, decimal velmax, string motor, int alas, int turbinas, string combustible,int cantPasajeros, string aerolinea):base(modelo,velmax,motor,alas,turbinas,combustible)
        {
            CantPasajeros = cantPasajeros;
            Aerolinea = aerolinea;
        }
    }
}
