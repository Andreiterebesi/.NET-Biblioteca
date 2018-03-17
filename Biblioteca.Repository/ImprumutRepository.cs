using Biblioteca.Repository.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Repository.Entity;
using Biblioteca.Repository.Repo;

namespace Biblioteca.Repository
{
    public class ImprumutRepository : IImprumutRepository
    {
        private readonly IRepository<ImprumutEntity> _imprumutRepository;

        public List<ImprumutEntity> GetImprumutID()
        {
            return GetImprumutID();
        }
    }
}
