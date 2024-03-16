using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    public class Empleado : Usuario
    {
        public double Sueldo { get; set; }
        public Empleado(string Nombre, double Saldo, double sueldo) : base(Nombre, Saldo)
        {
            Sueldo = sueldo;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Sueldo: {Sueldo}");
        }
    }
}
