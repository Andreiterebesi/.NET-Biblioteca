using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Repository.Entity
{
    [Table("dbo.Biblioteca")]
    public class CarteEntity
    {
        [Key]
        public int CarteId { get; set; }

        public string Titlu { get; set; }

        public string Autor { get; set; }

        public string Editura { get; set; }

        public int AnAparitie { get; set; }
    }
}
