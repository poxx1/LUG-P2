using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace BLL_Negocio
{
    class XML
    {
        public string documents = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public List<Object> Read()
        {
            string path = documents + @"UAI\LUG\LUG-P2\Documents\file.xml";

            var query = from Programs in XElement.Load(path).Elements("Programs")
                        select new Object //Aca reemplazo por la clase BE_Clients o lo que sea
                        {
                            //Aca van las propiedades de BE_Programas
                           // name = Convert.ToString(Programs.Attribute("Program").Value).Trim(),
                           // version = Convert.ToString(Programs.Attribute("Program").Value).Trim()
                        };
            List<Object> Lista = query.ToList<Object>();
            return Lista;

        }

        public void Write(string uno, string dos, string tres)
        {
            string path = documents + @"UAI\LUG\LUG-P2\Documents\file.xml";
            XDocument doc = XDocument.Load(path);

            doc.Element("Programs").Add(new XElement("Programs",
                new XAttribute("Program",uno),
                new XElement("version",dos),
                new XElement("platofm",tres)
                ));

            doc.Save(path);

        }

        public void Create(string uno, string dos, string tres)
        {
            string path = documents + @"UAI\LUG\LUG-P2\Documents\file.xml";

            var file = new XmlTextWriter(path,System.Text.Encoding.UTF8);
            file.Formatting = Formatting.Indented;

            file.Indentation = 2;
            file.WriteStartDocument(true);
            
            file.WriteStartElement("Programs");
            file.WriteAttributeString("Program Atributo", uno);
            
            file.WriteElementString("element Version", dos);
            file.WriteElementString("element Platform", tres);
            
            file.WriteEndElement();
            file.Close();
        }
    }
}
