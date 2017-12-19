namespace cbaUtility
{

    public class Mangel
    {
        public int id { get; set; }
        public decimal lokale { get; set; }
        public string prio { get; set; }
        public string dato { get; set; }
        public string beskrivelse { get; set; }
        public bool manglerLys { get; set; }
        public bool manglerProjekter { get; set; }
        public bool manglerBorde { get; set; }
        public bool manglerStole { get; set; }
    }
}