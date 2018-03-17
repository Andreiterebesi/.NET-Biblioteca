using Biblioteca.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Repository.Ports
{
    public interface IClientRepository
    {
        List<ClientEntity> GetClientID();

        
    }
}
