using System;

namespace Models
{
    public abstract class  Kategori
    {
        public string kategori { get; set; }

        public Kategori(String kategori)
        {
            this.kategori = kategori;
        }
    }
}
