using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab02
{
    internal class Serializator
    {
        
        public static void Serialize(Owners owner)
        {
            Bank.ownersCollections.ToList().ForEach(item => owner.owners.Add(item));

            XmlSerializer serializer = new XmlSerializer(typeof(Owners));
            using (FileStream fileStream = new FileStream(@"..\..\..\Owner.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fileStream, owner);
            }
        }
        public static void Deserialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Owners));
            using (FileStream fileStream = new FileStream(@"..\..\..\Owner.xml", FileMode.OpenOrCreate))
            {
                var list = (Owners)serializer.Deserialize(fileStream);
                list.owners.ForEach(item => Bank.ownersCollections.Add(item));
            }
        }

    }
}
