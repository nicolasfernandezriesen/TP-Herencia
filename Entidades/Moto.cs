using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto:VehiculoTerrestre
    {
        public string Cilindrado  { get; set; }
        public string Marca { get; set; }
        public bool Sidecar { get; set; }
        public Moto() { }

        public Moto(string modelo, decimal velmax, string motor, string traccion, string tipo, string cilindrado, string marca, bool sidecar) : base(modelo, velmax, motor, traccion, tipo)
        {
            this.Cilindrado = cilindrado;
            this.Marca = marca;
            this.Sidecar = sidecar;
        }

    }
}
