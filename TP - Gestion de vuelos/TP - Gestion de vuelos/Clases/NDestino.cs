using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___Gestion_de_vuelos
{
    class NDestino
    {
        public static string Insertar(string iddestino, string lugardestino, string idpais, 
                                      string aeropuerto, int importedestino)
        {
            DatosDestinos Obj = new DatosDestinos();
            Obj.IdDestino = iddestino;
            Obj.LugarDestino = lugardestino;
            Obj.IdPais = idpais;
            Obj.Aeropuerto = aeropuerto;
            Obj.ImporteDestino = importedestino;
            return Obj.Insertar(Obj);
        }

        public static string Editar(string iddestino, string lugardestino, string idpais,
                                    string aeropuerto, int importedestino)
        {
            DatosDestinos Obj = new DatosDestinos();
            Obj.IdDestino = iddestino;
            Obj.LugarDestino = lugardestino;
            Obj.IdPais = idpais;
            Obj.Aeropuerto = aeropuerto;
            Obj.ImporteDestino = importedestino;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(string iddestino, string lugardestino, string idpais,
                                      string aeropuerto, int importedestino)
        {
            DatosDestinos Obj = new DatosDestinos();
            Obj.IdDestino = iddestino;
            Obj.LugarDestino = lugardestino;
            Obj.IdPais = idpais;
            Obj.Aeropuerto = aeropuerto;
            Obj.ImporteDestino = importedestino;
            return Obj.Eliminar(Obj);
        }
    }
}
