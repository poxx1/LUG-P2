using BE_Propiedades;
using DAL_SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Mapper
{
    public class M_Servicios
    {
        public List<BE_Servicios> Load()
        {
            var Ds = new DataSet();
            var d = new Conexiones();
            var Lista = new List<BE_Servicios>();

            var srv = new BE_Servicios();

            int servicio;

            string query = "Select Codigo,Calidad,Nombre,Minutos,Fecha,Costo,Tipo from Transmisiones";

            Ds = d.ReadDS(query);

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {
                    srv.Codigo = Int32.Parse(fila[0].ToString());
                    srv.Calidad = fila[1].ToString();
                    srv.Minutos= Int32.Parse(fila[3].ToString());
                    srv.Nombre = fila[2].ToString();
                    srv.Costo = Int32.Parse(fila[5].ToString());
                    srv.Fecha = Convert.ToDateTime(fila[4].ToString());
                    srv.Tipo = fila[6].ToString();

                    Lista.Add(srv);
                
                }//Cierra el forich

            }

            else
                Lista = null;

            return Lista;
        }

    }
}
