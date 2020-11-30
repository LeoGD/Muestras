using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TP___Gestion_de_vuelos
{
    class GestionarPagos
    {
        public bool Insertar(DatosPagos Pago)
        {
            Conexion datos = new Conexion();
            SqlCommand comando = new SqlCommand();
            int cantFilasAfectadas;
            bool estado;

            // A un SQLCommand le cargo los parametros del procedimiento almacenado
            
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDPAGO", SqlDbType.Char, 10);
            SqlParametros.Value = Pago.IdPago;
            SqlParametros = comando.Parameters.Add("@CLIENTE", SqlDbType.Char, 10);
            SqlParametros.Value = Pago.Cliente;
            SqlParametros = comando.Parameters.Add("@IMPORTETOTAL", SqlDbType.Int);
            SqlParametros.Value = Pago.Total;


            cantFilasAfectadas = datos.EjecutarProcedimientoAlmacenado(comando, "spInsertarPago");

            if (cantFilasAfectadas == 1)
                estado = true;
            else
                estado = false;

            return estado;
        }



    }

}
