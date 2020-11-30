using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace TP___Gestion_de_vuelos
{
    class GestionarDestinos
    {
        public bool Insertar(DatosDestinos Destino)
        {
            Conexion datos = new Conexion();
            SqlCommand comando = new SqlCommand();
            int cantFilasAfectadas;
            bool estado;

            // A un SQLCommand le cargo los parametros del procedimiento almacenado

          
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDDESTINO", SqlDbType.Char, 10);
            SqlParametros.Value = Destino.IdDestino;
            SqlParametros = comando.Parameters.Add("@IDPAIS", SqlDbType.Char, 10);
            SqlParametros.Value = Destino.IdPais;
            SqlParametros = comando.Parameters.Add("@LUGARDESTINO", SqlDbType.Char, 10);
            SqlParametros.Value = Destino.LugarDestino;
            SqlParametros = comando.Parameters.Add("@AEROPUERTO", SqlDbType.Char, 50);
            SqlParametros.Value = Destino.Aeropuerto;
            SqlParametros = comando.Parameters.Add("IMPORTEDESTINO", SqlDbType.Char, 50);
            SqlParametros.Value = Destino.ImporteDestino;
            

            cantFilasAfectadas = datos.EjecutarProcedimientoAlmacenado(comando, "spInsertarDestino");

            if (cantFilasAfectadas == 1)
                estado = true;
            else
                estado = false;

            return estado;
        }
        public bool Modificar(DatosDestinos Destino)
        {
            Conexion datos = new Conexion();
            SqlCommand comando = new SqlCommand();
            int cantFilasAfectadas;
            bool estado;

            // A un SQLCommand le cargo los parametros del procedimiento almacenado


            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDDESTINO", SqlDbType.Char, 10);
            SqlParametros.Value = Destino.IdDestino;
            //SqlParametros = comando.Parameters.Add("@IDPAIS", SqlDbType.Char, 10);
            //SqlParametros.Value = Destino.IdPais;
            //SqlParametros = comando.Parameters.Add("@LUGARDESTINO", SqlDbType.Char, 10);
            //SqlParametros.Value = Destino.LugarDestino;
            //SqlParametros = comando.Parameters.Add("@AEROPUERTO", SqlDbType.Char, 50);
            //SqlParametros.Value = Destino.Aeropuerto;
            SqlParametros = comando.Parameters.Add("IMPORTEDESTINO", SqlDbType.Char, 50);
            SqlParametros.Value = Destino.ImporteDestino;


            cantFilasAfectadas = datos.EjecutarProcedimientoAlmacenado(comando, "spActualizarDestino");

            if (cantFilasAfectadas == 1)
                estado = true;
            else
                estado = false;

            return estado;
        }
    }
}
