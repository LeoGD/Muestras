using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___Gestion_de_vuelos
{
    class NVuelo
    {
        public static string Insertar(string idvuelo, string iddestino, string idavion, 
                                      DateTime fechavuelo, int montovuelo)
        {
            DatosVuelos Obj = new DatosVuelos();
            Obj.IdVuelo = idvuelo;
            Obj.IdDestino = iddestino;
            Obj.IdAvion = idavion;
            Obj.FechaVuelo = fechavuelo;
            Obj.MontoVuelo = montovuelo;
            return Obj.Insertar(Obj);
        }

        public static string Editar(string idvuelo, string iddestino, string idavion,
                                    DateTime fechavuelo, int montovuelo)
        {
            DatosVuelos Obj = new DatosVuelos();
            Obj.IdVuelo = idvuelo;
            Obj.IdDestino = iddestino;
            Obj.IdAvion = idavion;
            Obj.FechaVuelo = fechavuelo;
            Obj.MontoVuelo = montovuelo;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string idvuelo, string iddestino, string idavion,
                                      DateTime fechavuelo, int montovuelo)
        {
            DatosVuelos Obj = new DatosVuelos();
            Obj.IdVuelo = idvuelo;
            Obj.IdDestino = iddestino;
            Obj.IdAvion = idavion;
            Obj.FechaVuelo = fechavuelo;
            Obj.MontoVuelo = montovuelo; 
            return Obj.Eliminar(Obj);
        }
    }
}
