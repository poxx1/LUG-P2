using BE_Propiedades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace BLL_Negocio
{
   public class XML
    {
        public string documents = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public List<BE_Servicios> Read()
        {
            string path = documents + @"\UAI\LUG\LUG-P2\Documents\file.xml";

            var query = from Servicio in XElement.Load(path).Elements("Servicio")
                        select new BE_Servicios //Aca reemplazo por la clase BE_Clients o lo que sea
                        {
                            //Aca van las propiedades de BE_Programas
                            Tipo = Convert.ToString(Servicio.Attribute("Tipo").Value).Trim(),

                            Calidad = Convert.ToString(Servicio.Attribute("Calidad").Value).Trim(),

                            Nombre = Convert.ToString(Servicio.Attribute("Nombre").Value).Trim(),

                            Minutos = Int32.Parse(Convert.ToString(Servicio.Attribute("Minutos").Value).Trim()),

                            Fecha = Convert.ToDateTime(Convert.ToString(Servicio.Attribute("Fecha").Value).Trim())
                            
                        };
            List<BE_Servicios> Lista = query.ToList<BE_Servicios>();
            return Lista;

        }

        public void Write(string Servicio, string Calidad, string Nombre, string Minutos, string Fecha)
        {
            string path = documents + @"\UAI\LUG\LUG-P2\Documents\file.xml";
            XDocument doc = XDocument.Load(path);

            doc.Element("Servicio").Add(new XElement("Streaming",
                new XAttribute("Tipo",Servicio),
                new XElement("Calidad",Calidad),
                new XElement("Nombre", Nombre),
                new XElement("Minutos", Minutos),
                new XElement("Fecha",Fecha)
                ));

            doc.Save(path);
        }

        public void Create(string Servicio, string Calidad, string Nombre, string Minutos, string Fecha)
        {
            string path = documents + @"\UAI\LUG\LUG-P2\Documents\file.xml";

            var file = new XmlTextWriter(path,System.Text.Encoding.UTF8);
            file.Formatting = Formatting.Indented;

            file.Indentation = 2;
            file.WriteStartDocument(true);
            
            file.WriteStartElement("Servicio");

            file.WriteStartElement("Streaming", Calidad);
            file.WriteAttributeString("Tipo", Servicio);

            file.WriteElementString("Calidad", Calidad);
            file.WriteElementString("Nombre", Nombre);
            file.WriteElementString("Minutos", Minutos);
            file.WriteElementString("Fecha", Fecha);

            file.WriteEndElement();
            file.Close();
        }
    }
}
