// See https://aka.ms/new-console-template for more information
using Laboratorio01;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        bool exit = false;

        Grifo grifo = new Grifo();

        while (!exit)
        {
            string menu = "1 - Mostrar información de usuarios\n" +
                      "2 - Agregar Cliente\n" +
                      "3 - Agregar Empleado\n" +
                      "4 - Salir\n";

            Console.WriteLine(menu);
            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    grifo.MostrarUsuarios();
                    break;
                case "2":
                    Console.WriteLine("Nombre:");
                    string nombre_cli = Console.ReadLine();

                    Console.WriteLine("Saldo:");
                    string saldo_cli = Console.ReadLine();

                    Console.WriteLine("Litros:");
                    string litros = Console.ReadLine();

                    Cliente cliente = new Cliente(nombre_cli, Convert.ToDouble(saldo_cli), Convert.ToDouble(litros));
                    grifo.Usuarios.Add(cliente);
                    break;
                case "3":
                    Console.WriteLine("Nombre:");
                    string nombre_emp = Console.ReadLine();

                    Console.WriteLine("Saldo:");
                    string saldo_emp = Console.ReadLine();

                    Console.WriteLine("Sueldo:");
                    string sueldo = Console.ReadLine();

                    Empleado empleado = new Empleado(nombre_emp, Convert.ToDouble(saldo_emp), Convert.ToDouble(sueldo));
                    grifo.Usuarios.Add(empleado);
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
