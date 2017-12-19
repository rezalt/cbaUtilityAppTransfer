using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbaUtility.Data
{
    class lokalerJSON
    {
        public static string lokaler = "[{\"id\":1,\"lokale\":1.01,\"pladser\":28},{\"id\":2,\"lokale\":1.03,\"pladser\":36},{\"id\":3,\"lokale\":1.05,\"pladser\":36},{\"id\":4,\"lokale\":1.10,\"optaget\":1,\"pladser\":0},{\"id\":5,\"lokale\":1.12,\"pladser\":0},{\"id\":6,\"lokale\":1.14,\"pladser\":0},{\"id\":7,\"lokale\":1.15,\"pladser\":0},{\"id\":8,\"lokale\":1.16,\"pladser\":0},{\"id\":9,\"lokale\":1.20,\"pladser\":0},{\"id\":10,\"lokale\":1.21,\"pladser\":0},{\"id\":11,\"lokale\":1.22,\"pladser\":0},{\"id\":12,\"lokale\":1.23,\"pladser\":0},{\"id\":13,\"lokale\":1.24,\"pladser\":0},{\"id\":14,\"lokale\":1.33,\"pladser\":0},{\"id\":15,\"lokale\":1.34,\"pladser\":0},{\"id\":16,\"lokale\":1.35,\"pladser\":0},{\"id\":17,\"lokale\":1.36,\"pladser\":0},{\"id\":18,\"lokale\":1.37,\"pladser\":0},{\"id\":19,\"lokale\":1.38,\"pladser\":0},{\"id\":20,\"lokale\":1.39,\"pladser\":0},{\"id\":21,\"lokale\":1.40,\"pladser\":0},{\"id\":22,\"lokale\":1.60,\"pladser\":24},{\"id\":23,\"lokale\":1.62,\"pladser\":36},{\"id\":24,\"lokale\":1.64,\"pladser\":36},{\"id\":25,\"lokale\":1.66,\"pladser\":36},{\"id\":26,\"lokale\":2.01,\"pladser\":28},{\"id\":27,\"lokale\":2.03,\"pladser\":36},{\"id\":28,\"lokale\":2.05,\"pladser\":36},{\"id\":29,\"lokale\":2.60,\"pladser\":24},{\"id\":30,\"lokale\":2.62,\"pladser\":36},{\"id\":31,\"lokale\":2.64,\"pladser\":36},{\"id\":32,\"lokale\":2.66,\"pladser\":36}]";
        public string GetJSON()
        {
            return lokaler;
        }
    }
}
