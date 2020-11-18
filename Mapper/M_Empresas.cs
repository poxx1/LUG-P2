using BLL_Negocio;
using System;
using System.Collections.Generic;
using System.Text;
using DAL_SQL;
using BE_Propiedades;

namespace Mapper
{
    public class M_Empresas
    {
        public bool Insert(BE_Empresas l)
        {
            var a = new Conexiones();
            var query = "INSERT into Empresas (Codigo,RazonSocial,CUIT,Correo,Servicio) VALUES ('" + l.Codigo + "','" + l.RazonSocial + "','" + l.Cuit + "','" + l.Correo + "','" + l.Servicio + "');";
            return a.Write(query);
        }

        public bool Update(BE_Empresas l)
        {
            var a = new Conexiones();
            var query = "UPDATE Empresas SET Nombre_Localidad = '" + l.Codigo + "' WHERE ID_Localidad = " + l.RazonSocial + "";
            return a.Write(query);
        }

        public bool Delete(BE_Empresas l)
        {
            var a = new Conexiones();
            var query = "DELETE FROM Empresas WHERE ID_Localidad = " + l.Codigo + "";
            return a.Write(query);
        }
    }
}
