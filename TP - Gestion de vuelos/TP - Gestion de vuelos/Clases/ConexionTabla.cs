using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TP___Gestion_de_vuelos
{
    class ConexionTabla
    {
            public static DataTable devuelveTabla(string consulta, String nombreTabla)
            {
                DataSet ds = new DataSet();
                Conexion datos = new Conexion();
                SqlDataAdapter adp = datos.ObtenerAdaptador(consulta);
                adp.Fill(ds, nombreTabla);
                return ds.Tables[nombreTabla];
            }
    }
}
