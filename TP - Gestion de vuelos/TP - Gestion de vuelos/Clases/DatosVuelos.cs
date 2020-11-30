using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TP___Gestion_de_vuelos
{
    class DatosVuelos
    {
        Conexion Cn = new Conexion();

        private string _IdVuelo;
        private string _IdDestino;
        private string _IdAvion;
        private DateTime _FechaVuelo;
        private int _MontoVuelo;
        public string IdVuelo
        {
            get { return _IdVuelo; }
            set { _IdVuelo = value; }
        }
        public string IdDestino
        {
            get { return _IdDestino; }
            set { _IdDestino = value; }
        }
        public string IdAvion
        {
            get { return _IdAvion; }
            set { _IdAvion = value; }
        }
        
        public DateTime FechaVuelo
        {
            get { return _FechaVuelo; }
            set { _FechaVuelo = value; }
        }
        
        public int MontoVuelo
        {
            get { return _MontoVuelo; }
            set { _MontoVuelo = value; }
        }
        //Cnstructor vacío
        public DatosVuelos()
        {

        }
        //Constructor con parámetros
        public DatosVuelos(string idvuelo,string iddestino,string idavion,DateTime fechavuelo,
                           int montovuelo)
        {
            this.IdVuelo = idvuelo;
            this.IdDestino = iddestino;
            this.IdAvion = idavion;
            this.FechaVuelo = fechavuelo;
            this.MontoVuelo = montovuelo;
        }

        //Método Insertar
        public string Insertar(DatosVuelos Vuelo)
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
                SqlCmd.CommandText = "spInsertarVuelo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdvuelo = new SqlParameter();
                ParIdvuelo.ParameterName = "@IDVUELO";
                ParIdvuelo.SqlDbType = SqlDbType.Char;
                ParIdvuelo.Size = 10;
                ParIdvuelo.Value = Vuelo.IdVuelo;
                SqlCmd.Parameters.Add(ParIdvuelo);

                SqlParameter ParIddestino = new SqlParameter();
                ParIddestino.ParameterName = "@IDDESTINO";
                ParIddestino.SqlDbType = SqlDbType.Char;
                ParIddestino.Size = 10;
                ParIddestino.Value = Vuelo.IdDestino;
                SqlCmd.Parameters.Add(ParIddestino);

                SqlParameter ParIdavion = new SqlParameter();
                ParIdavion.ParameterName = "@IDAVION";
                ParIdavion.SqlDbType = SqlDbType.Char;
                ParIdavion.Size = 10;
                ParIdavion.Value = Vuelo.IdAvion;
                SqlCmd.Parameters.Add(ParIdavion);

                SqlParameter ParFechavuelo = new SqlParameter();
                ParFechavuelo.ParameterName = "@FECHAVUELO";
                ParFechavuelo.SqlDbType = SqlDbType.SmallDateTime;
                //ParFechavuelo.Size = 50;
                ParFechavuelo.Value = Vuelo.FechaVuelo;
                SqlCmd.Parameters.Add(ParFechavuelo);

                SqlParameter ParMontovuelo = new SqlParameter();
                ParMontovuelo.ParameterName = "@MONTOVUELO";
                ParMontovuelo.SqlDbType = SqlDbType.SmallDateTime;
                //ParFechaNac.Size = 8;
                ParMontovuelo.Value = Vuelo.MontoVuelo;
                SqlCmd.Parameters.Add(ParMontovuelo);

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
        public string Editar(DatosVuelos Vuelo)
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
                SqlCmd.CommandText = "spActualizarVuelo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdavion = new SqlParameter();
                ParIdavion.ParameterName = "@IDAVION";
                ParIdavion.SqlDbType = SqlDbType.Char;
                ParIdavion.Size = 10;
                ParIdavion.Value = Vuelo.IdAvion;
                SqlCmd.Parameters.Add(ParIdavion);

                SqlParameter ParFechavuelo = new SqlParameter();
                ParFechavuelo.ParameterName = "@FECHAVUELO";
                ParFechavuelo.SqlDbType = SqlDbType.SmallDateTime;
                //ParFechavuelo.Size = 50;
                ParFechavuelo.Value = Vuelo.FechaVuelo;
                SqlCmd.Parameters.Add(ParFechavuelo);

                SqlParameter ParMontovuelo = new SqlParameter();
                ParMontovuelo.ParameterName = "@MONTOVUELO";
                ParMontovuelo.SqlDbType = SqlDbType.SmallDateTime;
                //ParFechaNac.Size = 8;
                ParMontovuelo.Value = Vuelo.MontoVuelo;
                SqlCmd.Parameters.Add(ParMontovuelo);

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
        public string Eliminar(DatosVuelos Vuelo)
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
                SqlCmd.CommandText = "spEliminarVuelo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdVuelo = new SqlParameter();
                
                ParIdVuelo.ParameterName = "@IDVUELO";
                ParIdVuelo.SqlDbType = SqlDbType.Char;
                ParIdVuelo.Size = 10;
                ParIdVuelo.Value = Vuelo.IdVuelo;
                SqlCmd.Parameters.Add(ParIdVuelo);

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
