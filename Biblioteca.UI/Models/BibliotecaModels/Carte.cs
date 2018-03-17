using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.UI.Models.BibliotecaModels
{
    public class Carte
    {
        public int CarteID { get; set; }

        public string Titlu { get; set; }

        public string Autor { get; set; }

        [Range(1900, 2016), Display(Name = "Anul aparitiei")]
        public string AnAparitie { get; set; }
    }
}