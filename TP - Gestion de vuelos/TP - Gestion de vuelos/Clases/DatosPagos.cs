using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___Gestion_de_vuelos
{
    class DatosPagos
    {
        Conexion Cn = new Conexion();

        private string _IdPago;
        private string _Cliente;
        private string _IdDetalle;
        private int _Total;


  
        public string IdPago
        {
            get { return _IdPago; }
            set {_IdPago = value;}

        }
        public string IdDetalle
        {
            get { return _IdDetalle;}
            set { _IdDetalle = value;}
             
        }
        public string Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }

        }
        public int Total
        {
            get { return _Total; }
            set { _Total = value; }
        }
    
        public DatosPagos()
        {

        }
      
        public DatosPagos(string idPago,string cliente,int total)
        {
            this.IdPago = idPago;
            this.Cliente = cliente;
            this.Total = total;
            
        }
    }
}
