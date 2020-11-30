using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TP___Gestion_de_vuelos
{
    class DatosDetallePago
    {
        Conexion Cn = new Conexion();

        private string _IdPago;
        //private string _IdDetalle;
        private string _IdVuelo;
        private string _IdPasajero;
        private string _IdClase;
        private string _MontoVuelo;


  
        public string IdPago
        {
            get { return _IdPago; }
            set {_IdPago = value;}

        }
        /*public string IdDetalle
        {
            get { return _IdDetalle;}
            set { _IdDetalle = value;}
             
        }*/
        public string IdVuelo
        {
            get { return _IdVuelo; }
            set { _IdVuelo = value; }

        }
        public string IdPasajero
        {
            get { return _IdPasajero; }
            set { _IdPasajero = value; }
        }
        public string IdClase
        {
            get { return _IdClase; }
            set { _IdClase = value; }
        }
        public string Monto
        {
            get { return _MontoVuelo; }
            set { _MontoVuelo = value; }
        }
        public DatosDetallePago()
        {

        }
      
        public DatosDetallePago(string idPago,/*string IdDetalle*/string IdVuelo,string IdPasajero,string IdClase,string MontoVuelo)
        {
            this.IdPago = idPago;
            //this.IdDetalle = IdDetalle;
            this.IdVuelo = IdVuelo;
            this.IdPasajero = IdPasajero;
            this.IdClase = IdClase;
            this.Monto = MontoVuelo;
            
        }
    }
}
