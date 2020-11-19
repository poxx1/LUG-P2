using BE_Propiedades;
using System;
using System.Collections.Generic;
using System.Text;
using Mapper;


namespace BLL_Negocio
{
    public class N_Servicios
    {
        public List<BE_Servicios> Load()
        {
            //instancio un objeto de la clase Mapper y esta interacture con la BD
            var mj = new M_Servicios();
            return mj.Load();
        }
    }
}
