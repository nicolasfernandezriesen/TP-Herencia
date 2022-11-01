using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoTerrestre:Vehiculo
    {
        public string Traccion { get; set; }
        public string Tipo { get; set; }


        public VehiculoTerrestre() { }
        public VehiculoTerrestre(string modelo, decimal velmax, string motor, string traccion, string tipo):base(modelo,velmax,motor)
        {
            Traccion = traccion;
            Tipo = tipo;
        }
    }
}
