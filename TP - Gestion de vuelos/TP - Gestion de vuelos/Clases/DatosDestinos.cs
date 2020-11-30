using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TP___Gestion_de_vuelos
{
    class DatosDestinos
    {
        Conexion Cn = new Conexion();

        private string _IdDestino;
        private string _LugarDestino;
        private string _IdPais;
        private string _Aeropuerto;
        private int _ImporteDestino;
        
        public string IdDestino
        {
          get { return _IdDestino; }
          set { _IdDestino = value; }
        }
        public string LugarDestino
        {
          get { return _LugarDestino; }
          set { _LugarDestino = value; }
        }
        public string IdPais
        {
          get { return _IdPais; }
          set { _IdPais = value; }
        }
        public string Aeropuerto
        {
          get { return _Aeropuerto; }
          set { _Aeropuerto = value; }
        }
        public int ImporteDestino
        {
          get { return _ImporteDestino; }
          set { _ImporteDestino = value; }
        }
        
        //Cnstructor vacío
        public DatosDestinos()
        {

        }
        //Constructor con parámetros
        public DatosDestinos(string iddestino,string lugardestino,string idpais,string aeropuerto,
                             int importedestino)
        {
            this.IdDestino = iddestino;
            this.LugarDestino = lugardestino;
            this.IdPais = idpais;
            this.Aeropuerto = aeropuerto;
            this.ImporteDestino = importedestino;
        }

        //Método Insertar
        public string Insertar(DatosDestinos Destino)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try 
            {
                SqlCon.ConnectionString = Conexion.ruta;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spInsertarDestino";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddestino = new SqlParameter();
                ParIddestino.ParameterName = "@IDDESTINO";
                ParIddestino.SqlDbType = SqlDbType.Char;
                ParIddestino.Size = 10;
                ParIddestino.Value = Destino.IdDestino;
                SqlCmd.Parameters.Add(ParIddestino);

                SqlParameter ParIdpais = new SqlParameter();
                ParIdpais.ParameterName = "@IDPAIS";
                ParIdpais.SqlDbType = SqlDbType.Char;
                ParIdpais.Size = 10;
                ParIdpais.Value = Destino.IdPais;
                SqlCmd.Parameters.Add(ParIdpais);

                SqlParameter ParLugardestino = new SqlParameter();
                ParLugardestino.ParameterName = "@LUGARDESTINO";
                ParLugardestino.SqlDbType = SqlDbType.Char;
                ParLugardestino.Size = 50;
                ParLugardestino.Value = Destino.LugarDestino;
                SqlCmd.Parameters.Add(ParLugardestino);

                SqlParameter ParAeropuerto = new SqlParameter();
                ParAeropuerto.ParameterName = "@AEROPUERTO";
                ParAeropuerto.SqlDbType = SqlDbType.Char;
                ParAeropuerto.Size = 50;
                ParAeropuerto.Value = Destino.Aeropuerto;
                SqlCmd.Parameters.Add(ParAeropuerto);

                SqlParameter ParImportedestino = new SqlParameter();
                ParImportedestino.ParameterName = "@IMPORTEDESTINO";
                ParImportedestino.SqlDbType = SqlDbType.SmallMoney;
                //ParFechaNac.Size = 8;
                ParImportedestino.Value = Destino.ImporteDestino;
                SqlCmd.Parameters.Add(ParImportedestino);

                // Ejecuto el comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingresó el Registro";
            }
            catch(Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta; 
        }

        //Método Editar
        public string Editar(DatosDestinos Destino)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.ruta;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spActualizarDestino";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpais = new SqlParameter();
                ParIdpais.ParameterName = "@IDPAIS";
                ParIdpais.SqlDbType = SqlDbType.Char;
                ParIdpais.Size = 10;
                ParIdpais.Value = Destino.IdPais;
                SqlCmd.Parameters.Add(ParIdpais);

                SqlParameter ParLugardestino = new SqlParameter();
                ParLugardestino.ParameterName = "@LUGARDESTINO";
                ParLugardestino.SqlDbType = SqlDbType.Char;
                ParLugardestino.Size = 50;
                ParLugardestino.Value = Destino.LugarDestino;
                SqlCmd.Parameters.Add(ParLugardestino);

                SqlParameter ParAeropuerto = new SqlParameter();
                ParAeropuerto.ParameterName = "@AEROPUERTO";
                ParAeropuerto.SqlDbType = SqlDbType.Char;
                ParAeropuerto.Size = 50;
                ParAeropuerto.Value = Destino.Aeropuerto;
                SqlCmd.Parameters.Add(ParAeropuerto);

                SqlParameter ParImportedestino = new SqlParameter();
                ParImportedestino.ParameterName = "@IMPORTEDESTINO";
                ParImportedestino.SqlDbType = SqlDbType.SmallMoney;
                //ParFechaNac.Size = 8;
                ParImportedestino.Value = Destino.ImporteDestino;
                SqlCmd.Parameters.Add(ParImportedestino);

                // Ejecuto el comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Actualizó el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Eliminar
        public string Eliminar(DatosDestinos Destino)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.ruta;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spEliminarDestino";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddestino = new SqlParameter();
                ParIddestino.ParameterName = "@IDDESTINO";
                ParIddestino.SqlDbType = SqlDbType.Char;
                ParIddestino.Size = 10;
                ParIddestino.Value = Destino.IdDestino;
                SqlCmd.Parameters.Add(ParIddestino);

              

                // Ejecuto el comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Eliminó el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
    }
}
