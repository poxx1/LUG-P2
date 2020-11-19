using System;
using System.Collections.Generic;
using System.Text;
using DAL_SQL;
using BE_Propiedades;
using System.Data;

namespace Mapper
{
    public class M_Empresas
    {
        public List<BE_Empresas> Load()
        {
            var Ds = new DataSet();
            var d = new Conexiones();
            var Lista = new List<BE_Empresas>();


            var emp = new BE_Empresas();
            var srv = new BE_Servicios();

            int servicio;

            string query = "Select Codigo,RazonSocial,CUIT,Correo,Servicio from Empresas";

            Ds = d.ReadDS(query);

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {
                    emp.Codigo = Int32.Parse(fila[0].ToString());
                    emp.RazonSocial = fila[1].ToString();
                    emp.Cuit = Int32.Parse(fila[2].ToString());
                    emp.Correo = fila[3].ToString();
                    emp.ServicioN = Int32.Parse(fila[4].ToString());

                    #region 1 - Muchos

                    #region Traer Servicios
                    servicio = emp.ServicioN;

                    string query2 = "Select Codigo,Calidad,Nombre,Minutos,Fecha from Transmisiones Where Codigo = " + servicio + "";

                    Ds = d.ReadDS(query2);

                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow fila2 in Ds.Tables[0].Rows)
                        {
                            srv.Tipo = fila2[0].ToString();
                            srv.Tipo = fila2[1].ToString();
                            srv.Tipo = fila2[2].ToString();
                            srv.Tipo = fila2[3].ToString();
                            srv.Tipo = fila2[4].ToString();

                            emp.Servicio = srv;

                            Lista.Add(emp);


                        }
                    }

                    else
                        Lista = null;
                    #endregion

                    #endregion

                }//Cierra el forich
            
            }

            else
                Lista = null;

            return Lista;
        }

        public bool Insert(BE_Empresas l)
        {
            var a = new Conexiones();
            var query = "INSERT into Empresas (Codigo,RazonSocial,CUIT,Correo,Servicio) VALUES ('" + l.Codigo + "','" + l.RazonSocial + "','" + l.Cuit + "','" + l.Correo + "','" + l.ServicioN + "');";
            return a.Write(query);
        }

        public bool Update(BE_Empresas l)
        {
            var a = new Conexiones();
            var query = "UPDATE Empresas SET Codigo = "+l.Codigo+",RazonSocial = \'"+l.RazonSocial+"\',CUIT="+l.Cuit+",Correo=\'"+l.Correo+ "\',Servicio=" + l.ServicioN+" WHERE Codigo = " + l.Codigo + ";";
            return a.Write(query);
        }

        public bool Delete(BE_Empresas l)
        {
            var a = new Conexiones();
            var query = "DELETE FROM Empresas WHERE Codigo = " + l.Codigo + "";
            return a.Write(query);
        }
    }
}
