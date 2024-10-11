using CP2.Domain.Entities;

namespace CP2.Domain.Interfaces
{
    public interface IVendedorRepository
    {
        void Add(IVendedorRepository entity);
        IVendedorRepository GetById(int id);
        IEnumerable<IVendedorRepository> GetAll();
        void Update(IVendedorRepository entity);
        void Delete(int id);
        void Update(VendedorEntity entity);
        void Add(VendedorEntity entity);
        VendedorEntity? ObterPorId(int id);
        IEnumerable<VendedorEntity> ObterTodos();
        VendedorEntity? DeletarDados(int id);
    }

    public interface IVendedorService
    {
        void Add(VendedorEntity entity);
        VendedorEntity GetById(int id);
        IEnumerable<VendedorEntity> GetAll();
        void Update(VendedorEntity entity);
        void Delete(int id);
    }
}
