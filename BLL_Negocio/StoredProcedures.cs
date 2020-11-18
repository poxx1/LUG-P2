using BE_Propiedades;
using DAL_SQL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BLL_Negocio
{
    public class StoredProcedures
    {
        public void Insert(BE_Servicios srv,string query)
        {
            var c = new Conexiones();
            var aR = new ArrayList();

            if (srv.Codigo != 0)
            {
                var p1 = new SqlParameter();
                p1.ParameterName = "@Codigo";
                p1.Value = srv.Codigo;
                p1.SqlDbType = System.Data.SqlDbType.NVarChar;
                aR.Add(p1);
            }

            var p2 = new SqlParameter();
            p2.ParameterName = "@Calidad";
            p2.Value = srv.Calidad;
            p2.SqlDbType = System.Data.SqlDbType.Bit;
            aR.Add(p2);

            var p3 = new SqlParameter();
            p3.ParameterName = "@Nombre";
            p3.Value = srv.Nombre;
            p3.SqlDbType = System.Data.SqlDbType.NVarChar;
            aR.Add(p3);

            var p4 = new SqlParameter();
            p4.ParameterName = "@Minutos";
            p4.Value = srv.Minutos;
            p4.SqlDbType = System.Data.SqlDbType.Int;
            aR.Add(p4);

            var p5 = new SqlParameter();
            p5.ParameterName = "@Fecha";
            p5.Value = srv.Fecha;
            p5.SqlDbType = System.Data.SqlDbType.DateTime;
            aR.Add(p5);

            var p6 = new SqlParameter();
            p6.ParameterName = "@Costo";
            p6.Value = srv.Costo;
            p6.SqlDbType = System.Data.SqlDbType.Int;
            aR.Add(p6);

            var p7 = new SqlParameter();
            p7.ParameterName = "@Tipo";
            p7.Value = srv.Costo;
            p7.SqlDbType = System.Data.SqlDbType.Int;
            aR.Add(p7);

            c.Write(query, aR);
        }
    }
}
