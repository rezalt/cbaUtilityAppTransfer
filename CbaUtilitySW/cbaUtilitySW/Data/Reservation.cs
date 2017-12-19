using System.Collections.Generic;

namespace cbaUtility
{
    public class Info
    {
        public int reservationlimit { get; set; }
        public int reservationcount { get; set; }
    }

    public class Reservation
    {
        public string id { get; set; }
        public string startdate { get; set; }
        public string starttime { get; set; }
        public string enddate { get; set; }
        public string endtime { get; set; }
        public List<string> columns { get; set; }
    }

    public class RootObject
    {
        public List<string> columnheaders { get; set; }
        public Info info { get; set; }
        public List<Reservation> reservations { get; set; }
    }
}