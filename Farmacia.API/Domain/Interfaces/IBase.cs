using System.Collections.Generic;

namespace Farmacia.API.Domain.Interfaces
{
    public interface IBase<T> where T : class
    {
        
        List<T> GetAll();
        T GetId(int id);
        T Create(T cliente);
        void Delete(T id);
        void Update(T id);
    }
}