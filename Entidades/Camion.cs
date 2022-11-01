using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion:VehiculoTerrestre
    {
        
        public decimal CargaMax { get; set; }
        public string TipoDeCarga { get; set; }
        public Camion() { }

        public Camion(string modelo, decimal velmax, string motor, string traccion, string tipo, decimal cargamax, string tipodecarga) : base(modelo, velmax, motor, traccion, tipo)
        {
            this.CargaMax = cargamax;
            this.TipoDeCarga = tipodecarga; 
           
        }
    }
}
