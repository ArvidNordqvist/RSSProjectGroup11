using System;
using System.Xml.Serialization;

namespace Models
{
    [XmlInclude(typeof(Podd))]

    public class Podd : Kategori
    {
        public string Name { get; set; }
        public int Avsnitt { get; set; }
        public int Frekvens { get; set; }
        public Podd(string name, int avsnitt, int frekvens, string kategori)
            : base(kategori)
        {
            Name = name;
            Avsnitt = avsnitt;
            Frekvens = frekvens;
        }

    }
}

