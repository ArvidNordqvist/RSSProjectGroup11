using System;


namespace RSS_Läsare
{
    [XmlInclude(typeof(Podd))]

    public class Podd
    {
        public string Name { get; set; }
        public int Avsnitt { get; set; }
        public int Frekvens { get; set; }
        public string Kategori { get; set; }
        public Podd(string name, int avsnitt, int frekvens, string kategori)
        {
            Name = name;
            Avsnitt = avsnitt;
            Frekvens = frekvens;
            Kategori = kategori;
        }

    }
}

