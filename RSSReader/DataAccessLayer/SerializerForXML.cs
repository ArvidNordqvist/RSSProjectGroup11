using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using RSSReader.Models;

namespace DataAccessLayer
{
    internal class SerializerForXml
    {
        public void Serialize(List<Podd> poddList)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podd>));
                using (FileStream outFile = new FileStream("Podds.xml", FileMode.Create,
                    FileAccess.Write))
                {
                    xmlSerializer.Serialize(outFile, poddList);
                }
            }
            catch (Exception e)
            {
                throw new SerializerException("Podds.xml", "Could not serialize to the file");
            }
        }

        public List<Podd> Deserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podd>));
                using (FileStream inFile = new FileStream("Podds.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    return (List<Podd>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (Exception e)
            {
                throw new SerializerException("Podds.xml", "Could not deserialize the file.");
            }

        }
    }
}
