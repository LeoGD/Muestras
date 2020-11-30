using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TP___Gestion_de_vuelos
{
    class GestionarPasajeros
    {
        public GestionarPasajeros()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public bool Insertar(DatosPasajeros pasajero)
    {
        Conexion datos = new Conexion();
        SqlCommand comando = new SqlCommand();
        int cantFilasAfectadas;
        bool estado;

        // A un SQLCommand le cargo los parametros del procedimiento almacenado

        SqlParameter SqlParametros = new SqlParameter();
        SqlParametros = comando.Parameters.Add("@IDPASAJERO", SqlDbType.Char, 10);
        SqlParametros.Value = pasajero.IdPasajero;
        SqlParametros = comando.Parameters.Add("@DNI", SqlDbType.Char, 10);
        SqlParametros.Value = pasajero.DNI;
        SqlParametros = comando.Parameters.Add("@PASAPORTE", SqlDbType.Char, 10);
        SqlParametros.Value = pasajero.Pasaporte;
        SqlParametros = comando.Parameters.Add("@NOMBRE", SqlDbType.Char, 50);
        SqlParametros.Value = pasajero.Nombre;
        SqlParametros = comando.Parameters.Add("@APELLIDO", SqlDbType.Char, 50);
        SqlParametros.Value = pasajero.Apellido;
        SqlParametros = comando.Parameters.Add("@FECHANAC", SqlDbType.SmallDateTime);
        SqlParametros.Value = pasajero.FechaNac;
        SqlParametros = comando.Parameters.Add("@NACIONALIDAD", SqlDbType.Char, 50);
        SqlParametros.Value = pasajero.Nacionalidad;
        SqlParametros = comando.Parameters.Add("@TELEFONO", SqlDbType.Char, 50);
        SqlParametros.Value = pasajero.Telefono;
        SqlParametros = comando.Parameters.Add("@MAIL", SqlDbType.Char, 50);
        SqlParametros.Value = pasajero.Mail;

        cantFilasAfectadas = datos.EjecutarProcedimientoAlmacenado(comando, "spInsertarPasajeros");

        if (cantFilasAfectadas == 1)
            estado = true;
        else
            estado = false;

        return estado;
    }
    public bool Modificar(DatosPasajeros pasajero)
    {
        Conexion datos = new Conexion();
        SqlCommand comando = new SqlCommand();
        int cantFilasAfectadas;
        bool estado;

        // A un SQLCommand le cargo los parametros del procedimiento almacenado

        SqlParameter SqlParametros = new SqlParameter();
        SqlParametros = comando.Parameters.Add("@IDPASAJERO", SqlDbType.Char, 10);
        SqlParametros.Value = pasajero.IdPasajero;
        SqlParametros = comando.Parameters.Add("@DNI", SqlDbType.Char, 10);
        SqlParametros.Value = pasajero.DNI;
        SqlParametros = comando.Parameters.Add("@PASAPORTE", SqlDbType.Char, 10);
        SqlParametros.Value = pasajero.Pasaporte;
        SqlParametros = comando.Parameters.Add("@NOMBRE", SqlDbType.Char, 50);
        SqlParametros.Value = pasajero.Nombre;
        SqlParametros = comando.Parameters.Add("@APELLIDO", SqlDbType.Char, 50);
        SqlParametros.Value = pasajero.Apellido;
        SqlParametros = comando.Parameters.Add("@FECHANAC", SqlDbType.SmallDateTime);
        SqlParametros.Value = pasajero.FechaNac;
        SqlParametros = comando.Parameters.Add("@NACIONALIDAD", SqlDbType.Char, 50);
        SqlParametros.Value = pasajero.Nacionalidad;
        SqlParametros = comando.Parameters.Add("@TELEFONO", SqlDbType.Char, 50);
        SqlParametros.Value = pasajero.Telefono;
        SqlParametros = comando.Parameters.Add("@MAIL", SqlDbType.Char, 50);
        SqlParametros.Value = pasajero.Mail;

        cantFilasAfectadas = datos.EjecutarProcedimientoAlmacenado(comando, "spActualizarPasajero");

        if (cantFilasAfectadas == 1)
            estado = true;
        else
            estado = false;

        return estado;
    }
    }
}
