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
    public class CarteRepository : ICarteRepository
    {
        private readonly IRepository<CarteEntity> _carteRepository;

        public List<CarteEntity> GetCarti()
        {
            return GetCarti();
        }
    }
}
