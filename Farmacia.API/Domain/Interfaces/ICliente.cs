using System.Collections.Generic;
using Farmacia.API.Domain.Entities;

namespace Farmacia.API.Domain.Interfaces
{
    public interface ICliente
    {
        List<Cliente> GetAll();
        Cliente GetId(int id);
        Cliente Create(Cliente cliente);
        void Delete(Cliente id);
        void Update(Cliente id);
    }
}