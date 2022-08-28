using GestionDeposito.Modelo;
using System;
using System.Collections.Generic;

namespace GestionDeposito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var deposito = new Deposito()
            {
                Id = 1,
                Nombre = "Deposito 1",
                Pasillos = new List<Pasillo>() 
                {
                    new Pasillo()
                    {
                        IDPasillo = 0,
                        Nombre = "Pasillo 0"
                    },
                    new Pasillo(0, "Pasillo 0")
                }
            };

            //Le agrego pasillos
            deposito.Pasillos.Add(new Pasillo()
            {
                IDPasillo = 1,
                Nombre = "Pasillo 1"
            });
            deposito.Pasillos.Add(new Pasillo()
            {
                IDPasillo = 2,
                Nombre = "Pasillo 2"
            });
            deposito.Pasillos.Add(new Pasillo(3, "Pasillo 3"));
        }
    }
}
