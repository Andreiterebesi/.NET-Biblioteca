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
    public class ClientRepository : IClientRepository
    {
        private readonly IRepository<ClientEntity> _clientRepository;

        public List<ClientEntity> GetClientID()
        {
            return GetClientID();
        }
    }
}
