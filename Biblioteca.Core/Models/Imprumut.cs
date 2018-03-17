using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Core.Models
{
    public class Imprumut
    {
        public int ImprumutID { get; set; }

        public int ClientID { get; set; }

        public int CarteID { get; set; }

        public string DataImprumut { get; set; }
    }
}
