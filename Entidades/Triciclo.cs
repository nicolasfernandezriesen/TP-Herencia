using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Triciclo:VehiculoTerrestre
    {
       
        public string TipoDeUsuario { get; set; }
        public int CantCanastos { get; set; }
        public Triciclo() { }

        public Triciclo(string modelo, decimal velmax, string motor, string traccion, string tipo, string tipodeusuario, int cantcanastos) : base(modelo, velmax, motor, traccion, tipo)
        {
            
            this.TipoDeUsuario = tipodeusuario;
            this.CantCanastos = cantcanastos;
        }

    }
}
