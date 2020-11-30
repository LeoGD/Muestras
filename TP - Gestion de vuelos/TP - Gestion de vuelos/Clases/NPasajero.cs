using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___Gestion_de_vuelos
{
    class NPasajero
    {
        public static string Insertar(string idpasajero, string dni, string pasaporte, string nombre, 
                      string apellido, DateTime fechanac,string nacionalidad, string telefono, string mail)
        {
            DatosPasajeros Obj = new DatosPasajeros();
            Obj.IdPasajero = idpasajero;
            Obj.DNI = dni;
            Obj.Pasaporte = pasaporte;
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.FechaNac = fechanac;
            Obj.Nacionalidad = nacionalidad;
            Obj.Telefono = telefono;
            Obj.Mail = mail;
            return Obj.Insertar(Obj);
        }

        public static string Editar(string dni, string pasaporte, string nombre,
                      string apellido, DateTime fechanac, string nacionalidad, string telefono, string mail)
        {
            DatosPasajeros Obj = new DatosPasajeros();
            Obj.DNI = dni;
            Obj.Pasaporte = pasaporte;
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.FechaNac = fechanac;
            Obj.Nacionalidad = nacionalidad;
            Obj.Telefono = telefono;
            Obj.Mail = mail;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string idpasajero, string dni, string pasaporte, string nombre,
                      string apellido, DateTime fechanac, string nacionalidad, string telefono, string mail)
        {
            DatosPasajeros Obj = new DatosPasajeros();
            Obj.IdPasajero = idpasajero;
            Obj.DNI = dni;
            Obj.Pasaporte = pasaporte;
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.FechaNac = fechanac;
            Obj.Nacionalidad = nacionalidad;
            Obj.Telefono = telefono;
            Obj.Mail = mail;
            return Obj.Eliminar(Obj);
        }
    }
}
