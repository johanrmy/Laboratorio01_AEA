using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    public class Cliente : Usuario
    {
        public double LitrosCargados { get; set; }

        public Cliente(string Nombre, double Saldo, double litrosCargados) : base(Nombre, Saldo)
        {
            LitrosCargados = litrosCargados;
        }

        public override void MostrarInformacion()
        {
           base.MostrarInformacion();
            Console.WriteLine($"Litros: {LitrosCargados}");
        }

    }
}
