using BE_Propiedades;
using Mapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Negocio
{
    public class N_Empresas
    {
        public List<BE_Empresas> Load()
        {
            //instancio un objeto de la clase Mapper y esta interacture con la BD
            var mj = new M_Empresas();
            return mj.Load();
        }
        public bool Insert(BE_Empresas j)
        {
            var mj = new M_Empresas();
            return mj.Insert(j);
        }

        public bool Update(BE_Empresas j)
        {
            var mj = new M_Empresas();
            return mj.Update(j);
        }

        public bool Delete(BE_Empresas j)
        {
            var mj = new M_Empresas();
            return mj.Delete(j);
        }
    }
}
