using CP2.Domain.Entities;

namespace CP2.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        void Add(IFornecedorRepository entity);                  
        IFornecedorRepository GetById(int id);                   
        IEnumerable<IFornecedorRepository> GetAll();             
        void Update(IFornecedorRepository entity);                
        void Delete(int id);                  
    }

    public interface IFornecedorService
    {
        void Add(FornecedorEntity entity);
        FornecedorEntity GetById(int id);
        IEnumerable<FornecedorEntity> GetAll();
        void Update(FornecedorEntity entity);
        void Delete(int id);
    }
}
