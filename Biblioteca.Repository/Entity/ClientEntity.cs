using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Repository.Entity
{
    [Table("dbo.Biblioteca")]
   public class ClientEntity
    {
        [Key]
        public int ClientID { get; set; }

        public string Nume { get; set; }

        public string CNP { get; set; }

        public string Adresa { get; set; }

        public string Telefon { get; set; }
    }
}
