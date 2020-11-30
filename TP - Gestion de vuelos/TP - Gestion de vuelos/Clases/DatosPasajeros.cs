using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TP___Gestion_de_vuelos
{
    class DatosPasajeros
    {
        Conexion Cn = new Conexion();

        private string _IdPasajero;
        private string _DNI;
        private string _Pasaporte;
        private string _Nombre;
        private string _Apellido;
        private DateTime _FechaNac;
        private string _Nacionalidad;
        private string _Telefono;
        private string _Mail;
        public string IdPasajero
        {
            get { return _IdPasajero; }
            set { _IdPasajero = value; }
        }
        public string DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }
        public string Pasaporte
        {
            get { return _Pasaporte; }
            set { _Pasaporte = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        public DateTime FechaNac
        {
            get { return _FechaNac; }
            set { _FechaNac = value; }
        }
        public string Nacionalidad
        {
            get { return _Nacionalidad; }
            set { _Nacionalidad = value; }
        }
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }
        //Cnstructor vacío
        public DatosPasajeros()
        {

        }
        //Constructor con parámetros
        public DatosPasajeros(string idpasajero,string dni,string pasaporte,string nombre,string apellido,DateTime fechanac,
                              string nacionalidad,string telefono,string mail)
        {
            this.IdPasajero = idpasajero;
            this.DNI = dni;
            this.Pasaporte = pasaporte;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fechanac;
            this.Nacionalidad = nacionalidad;
            this.Telefono = telefono;
            this.Mail = mail;
        }

        //Método Insertar
        public string Insertar(DatosPasajeros Pasajero)
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
                SqlCmd.CommandText = "SP_InsertarPasajero";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpasajero = new SqlParameter();
                ParIdpasajero.ParameterName = "@IDPASAJERO";
                ParIdpasajero.SqlDbType = SqlDbType.Char;
                ParIdpasajero.Size = 10;
                ParIdpasajero.Value = Pasajero.IdPasajero;
                SqlCmd.Parameters.Add(ParIdpasajero);

                SqlParameter ParDNI = new SqlParameter();
                ParDNI.ParameterName = "@DNI";
                ParDNI.SqlDbType = SqlDbType.Char;
                ParDNI.Size = 10;
                ParDNI.Value = Pasajero.DNI;
                SqlCmd.Parameters.Add(ParDNI);

                SqlParameter ParPasaporte = new SqlParameter();
                ParPasaporte.ParameterName = "@PASAPORTE";
                ParPasaporte.SqlDbType = SqlDbType.Char;
                ParPasaporte.Size = 10;
                ParPasaporte.Value = Pasajero.Pasaporte;
                SqlCmd.Parameters.Add(ParPasaporte);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@NOMBRE";
                ParNombre.SqlDbType = SqlDbType.Char;
                ParNombre.Size = 50;
                ParNombre.Value = Pasajero.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParFechaNac = new SqlParameter();
                ParFechaNac.ParameterName = "@FECHANAC";
                ParFechaNac.SqlDbType = SqlDbType.SmallDateTime;
                //ParFechaNac.Size = 8;
                ParFechaNac.Value = Pasajero.FechaNac;
                SqlCmd.Parameters.Add(ParFechaNac);

                SqlParameter ParNacionalidad = new SqlParameter();
                ParNacionalidad.ParameterName = "@NACIONALIDAD";
                ParNacionalidad.SqlDbType = SqlDbType.Char;
                ParNacionalidad.Size = 50;
                ParNacionalidad.Value = Pasajero.Nacionalidad;
                SqlCmd.Parameters.Add(ParNacionalidad);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@TELEFONO";
                ParTelefono.SqlDbType = SqlDbType.Char;
                ParTelefono.Size = 50;
                ParTelefono.Value = Pasajero.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMail = new SqlParameter();
                ParMail.ParameterName = "@MAIL";
                ParMail.SqlDbType = SqlDbType.Char;
                ParMail.Size = 50;
                ParMail.Value = Pasajero.Mail;
                SqlCmd.Parameters.Add(ParMail);

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
        public string Editar(DatosPasajeros Pasajero)
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
                SqlCmd.CommandText = "spActualizarPasajero";
                SqlCmd.CommandType = CommandType.StoredProcedure;

              
                SqlParameter ParIdpasajero = new SqlParameter();
                ParIdpasajero.ParameterName = "@IDPASAJERO";
                ParIdpasajero.SqlDbType = SqlDbType.Char;
                ParIdpasajero.Size = 10;
                ParIdpasajero.Value = Pasajero.IdPasajero;
                SqlCmd.Parameters.Add(ParIdpasajero);

                SqlParameter ParDNI = new SqlParameter();
                ParDNI.ParameterName = "@DNI";
                ParDNI.SqlDbType = SqlDbType.Char;
                ParDNI.Size = 10;
                ParDNI.Value = Pasajero.DNI;
                SqlCmd.Parameters.Add(ParDNI);

                SqlParameter ParPasaporte = new SqlParameter();
                ParPasaporte.ParameterName = "@PASAPORTE";
                ParPasaporte.SqlDbType = SqlDbType.Char;
                ParPasaporte.Size = 10;
                ParPasaporte.Value = Pasajero.Pasaporte;
                SqlCmd.Parameters.Add(ParPasaporte);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@NOMBRE";
                ParNombre.SqlDbType = SqlDbType.Char;
                ParNombre.Size = 50;
                ParNombre.Value = Pasajero.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@APELLIDO";
                ParApellido.SqlDbType = SqlDbType.Char;
                ParApellido.Size = 50;
                ParApellido.Value = Pasajero.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParFechaNac = new SqlParameter();
                ParFechaNac.ParameterName = "@FECHANAC";
                ParFechaNac.SqlDbType = SqlDbType.SmallDateTime;
                //ParFechaNac.Size = 8;
                ParFechaNac.Value = Pasajero.FechaNac;
                SqlCmd.Parameters.Add(ParFechaNac);

                SqlParameter ParNacionalidad = new SqlParameter();
                ParNacionalidad.ParameterName = "@NACIONALIDAD";
                ParNacionalidad.SqlDbType = SqlDbType.Char;
                ParNacionalidad.Size = 50;
                ParNacionalidad.Value = Pasajero.Nacionalidad;
                SqlCmd.Parameters.Add(ParNacionalidad);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@TELEFONO";
                ParTelefono.SqlDbType = SqlDbType.Char;
                ParTelefono.Size = 50;
                ParTelefono.Value = Pasajero.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMail = new SqlParameter();
                ParMail.ParameterName = "@MAIL";
                ParMail.SqlDbType = SqlDbType.Char;
                ParMail.Size = 50;
                ParMail.Value = Pasajero.Mail;
                SqlCmd.Parameters.Add(ParMail);

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
        public string Eliminar(DatosPasajeros Pasajero)
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
                SqlCmd.CommandText = "spEliminarPasajero";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpasajero = new SqlParameter();
                ParIdpasajero.ParameterName = "@IDPASAJERO";
                ParIdpasajero.SqlDbType = SqlDbType.Char;
                ParIdpasajero.Size = 10;
                ParIdpasajero.Value = Pasajero.IdPasajero;
                SqlCmd.Parameters.Add(ParIdpasajero);

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

        //Método Mostrar
        /*public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Pasajeros");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.ruta;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch(Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Método BuscarIdCategoria
        public DataTable BuscarIdCategoria(DatosCategoria Categoria)
        {
           DataTable DtResultado = new DataTable("Categorías");
            
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_idcategoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@idcategoria";
                ParTextoBuscar.SqlDbType = SqlDbType.Int;
                ParTextoBuscar.Value = Categoria.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
               DtResultado = null;
            }
            return DtResultado;
        }
         */
    }
}
