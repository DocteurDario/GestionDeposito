using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeposito.Modelo
{
    internal class Pasillo
    {
        public int IDPasillo { get; set; }  
        public string Nombre { get; set; }
        public int IDCliente { get; set; }   
        public int IDContenedor { get; set; }   
        public LadoPasillo LADOPASILLO { get; set; }
        public bool Activo { get; set; }    

    }

    public enum LadoPasillo 
    {
        LadoA,
        LaboB
    }
}
