using System.Collections.Generic;

namespace GestionDeposito.Modelo
{
    public class Pasillo
    {
        public int IDPasillo { get; set; }
        public string Nombre { get; set; }
        public int IDCliente { get; set; }
        public int IDContenedor { get; set; }
        public bool Activo { get; set; }

        public Pasillo() 
        {
        }
        public Pasillo(int idPasillo, string nombre)
        {
            IDPasillo = idPasillo;
            Nombre = nombre;
        }
    }
}
