using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MountainBike:VehiculoTerrestre
    {
        public string Rodado  { get; set; }
        public string Material { get; set; }
        public bool Cambios { get; set; }
        public MountainBike() { }

        public MountainBike(string modelo, decimal velmax, string motor, string traccion, string tipo, string rodado, string material, bool cambios) : base(modelo, velmax, motor, traccion, tipo)
        {
            this.Rodado = rodado;
            this.Material = material;
            this.Cambios = cambios;
        }
    }
}
