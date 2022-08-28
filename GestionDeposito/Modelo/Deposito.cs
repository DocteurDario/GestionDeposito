using System.Collections.Generic;

namespace GestionDeposito.Modelo
{
    public class Deposito
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public List<Pasillo> Pasillos { get; set; } = new List<Pasillo>();
    }
}
