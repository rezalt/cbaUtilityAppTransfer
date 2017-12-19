using System;

namespace cbaUtility
{
    public class Lokale
    {
        public int id { get; set; }
        public decimal lokale { get; set; }
        public int pladser { get; set; }
        public bool mangler { get; set; }
        public bool optaget { get; set; }


        public static implicit operator Lokale(string v)
        {
            throw new NotImplementedException();
        }
    }
}