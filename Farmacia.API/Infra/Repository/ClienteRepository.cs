using System.Collections.Generic;
using Farmacia.API.Domain.Entities;
using Farmacia.API.Domain.Interfaces;
using Farmacia.API.Infra.Persistence;

namespace Farmacia.API.Infra.Repository
{
    public class ClienteRepository : ICliente
    {
        private readonly EFContext _context;
        public ClienteRepository(EFContext context)
        {
            _context = context;
        }
        
        public Cliente Create(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Cliente id)
        {
            throw new System.NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Cliente GetId(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Cliente id)
        {
            throw new System.NotImplementedException();
        }
    }
}