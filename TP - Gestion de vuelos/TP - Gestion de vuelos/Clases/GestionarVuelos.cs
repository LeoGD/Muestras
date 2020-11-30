using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TP___Gestion_de_vuelos
{
    class GestionarVuelos
    {
        public bool Insertar(DatosVuelos Vuelo)
        {
            Conexion datos = new Conexion();
            SqlCommand comando = new SqlCommand();
            int cantFilasAfectadas;
            bool estado;

            // A un SQLCommand le cargo los parametros del procedimiento almacenado


            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDVUELO", SqlDbType.Char, 10);
            SqlParametros.Value = Vuelo.IdVuelo;
            SqlParametros = comando.Parameters.Add("@IDDESTINO", SqlDbType.Char, 10);
            SqlParametros.Value = Vuelo.IdDestino;
            SqlParametros = comando.Parameters.Add("@IDAVION", SqlDbType.Char, 10);
            SqlParametros.Value = Vuelo.IdAvion;
            SqlParametros = comando.Parameters.Add("@FECHAVUELO", SqlDbType.SmallDateTime , 50);
            SqlParametros.Value = Vuelo.FechaVuelo;
            SqlParametros = comando.Parameters.Add("@MONTOVUELO", SqlDbType.Char, 50);
            SqlParametros.Value = Vuelo.MontoVuelo;
            

            cantFilasAfectadas = datos.EjecutarProcedimientoAlmacenado(comando, "spInsertarVuelos");

            if (cantFilasAfectadas == 1)
                estado = true;
            else
                estado = false;

            return estado;
        }
        public bool Modificar(DatosVuelos Vuelo)
        {
            Conexion datos = new Conexion();
            SqlCommand comando = new SqlCommand();
            int cantFilasAfectadas;
            bool estado;

            // A un SQLCommand le cargo los parametros del procedimiento almacenado


            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDVUELO", SqlDbType.Char, 10);
            SqlParametros.Value = Vuelo.IdVuelo;
           SqlParametros = comando.Parameters.Add("@IDAVION", SqlDbType.Char, 10);
            SqlParametros.Value = Vuelo.IdAvion;
            SqlParametros = comando.Parameters.Add("@FECHAVUELO", SqlDbType.SmallDateTime, 50);
            SqlParametros.Value = Vuelo.FechaVuelo;
            


            cantFilasAfectadas = datos.EjecutarProcedimientoAlmacenado(comando, "spActualizarVuelo");

            if (cantFilasAfectadas == 1)
                estado = true;
            else
                estado = false;

            return estado;
        }


    }
}
