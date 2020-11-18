using System;
using System.Collections.Generic;
using System.Text;

namespace BE_Propiedades
{
    public class BE_Empresas
    {
        public int Codigo { get; set; }
        public string RazonSocial { get; set; }
        public int Cuit { get; set; }
        public string Correo { get; set; }
        public BE_Servicios Servicio { get; set; }

        public int ServicioN { get; set; }

    }
}
