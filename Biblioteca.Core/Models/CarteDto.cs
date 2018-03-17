using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Core.Models
{
    public class CarteDto
    {
        public int CarteID { get; set; }

        public string Titlu { get; set; }

        public string Autor { get; set; }

        public string Editura { get; set; }

        public int AnAparitie { get; set; }
    }
}
