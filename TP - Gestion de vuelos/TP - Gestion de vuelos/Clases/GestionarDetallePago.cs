using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TP___Gestion_de_vuelos
{
    class GestionarDetallePago
    {
        public bool Insertar(DatosDetallePago DetallePago)
        {
            Conexion datos = new Conexion();
            SqlCommand comando = new SqlCommand();
            int cantFilasAfectadas;
            bool estado;

            // A un SQLCommand le cargo los parametros del procedimiento almacenado

            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDPAGO", SqlDbType.Char, 10);
            SqlParametros.Value = DetallePago.IdPago;
            //SqlParametros = comando.Parameters.Add("@IDDETALLEPAGO", SqlDbType.Char, 10);
            //SqlParametros.Value = DetallePago.IdPago;
            SqlParametros = comando.Parameters.Add("@IDVUELO", SqlDbType.Char, 10);
            SqlParametros.Value = DetallePago.IdVuelo;
            SqlParametros = comando.Parameters.Add("@PASAJERO", SqlDbType.Char, 10);
            SqlParametros.Value = DetallePago.IdPasajero;
            SqlParametros = comando.Parameters.Add("@IDCLASE", SqlDbType.Char, 50);
            SqlParametros.Value = DetallePago.IdClase;
            SqlParametros = comando.Parameters.Add("@SUBTOTAL", SqlDbType.Char, 50);
            SqlParametros.Value = DetallePago.Monto;


            cantFilasAfectadas = datos.EjecutarProcedimientoAlmacenado(comando, "spInsertarDetallePago");

            if (cantFilasAfectadas == 1)
                estado = true;
            else
                estado = false;

            return estado;
        }   
    }
}
