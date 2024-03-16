﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public double Saldo { get; set; }

        public Usuario(string nombre, double saldo)
        {
            Nombre = nombre;
            Saldo = saldo;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}\n Saldo: {Saldo}");
        }
    }
}
