using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Repository.Entity
{
    [Table("dbo.Biblioteca")]
    public class ImprumutEntity
    {
        [Key]
        public int ImprumutID { get; set; }

        public int ClientID { get; set; }

        public int CarteID { get; set; }

        public string DataImprumut { get; set; }
    }
}
