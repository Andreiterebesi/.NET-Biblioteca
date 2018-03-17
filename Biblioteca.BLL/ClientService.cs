using AutoMapper;
using Biblioteca.BLL.Ports;
using Biblioteca.Core.Models;
using Biblioteca.Repository;
using Biblioteca.Repository.Entity;
using Biblioteca.Repository.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BLL
{
    public class ClientService : IClientService
    {
        public Client GetClientID(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetClientID()
        {
            throw new NotImplementedException();
        }
    }

}
