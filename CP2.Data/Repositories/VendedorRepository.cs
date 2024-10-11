using CP2.Data.AppData;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;

namespace CP2.Data.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly List<VendedorEntity> _vendedores = new List<VendedorEntity>();

        public void Add(VendedorEntity entity)
        {
            _vendedores.Add(entity);
            Console.WriteLine($"Vendedor {entity.Nome} adicionado com sucesso.");
        }

        public VendedorEntity GetById(int id)
        {
            return _vendedores.FirstOrDefault(v => v.Id == id);
        }

        public IEnumerable<VendedorEntity> GetAll()
        {
            return _vendedores;
        }

        public void Update(VendedorEntity entity)
        {
            var vendedor = GetById(entity.Id);
            if (vendedor != null)
            {
                vendedor.Nome = entity.Nome;
                vendedor.Email = entity.Email;
                vendedor.Telefone = entity.Telefone;
                vendedor.DataNascimento = entity.DataNascimento;
                vendedor.Endereco = entity.Endereco;
                vendedor.DataContratacao = entity.DataContratacao;
                vendedor.ComissaoPercentual = entity.ComissaoPercentual;
                vendedor.MetaMensal = entity.MetaMensal;
                vendedor.CriadoEm = entity.CriadoEm;
                Console.WriteLine($"Vendedor {vendedor.Nome} atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Vendedor não encontrado.");
            }
        }

        public void Delete(int id)
        {
            var vendedor = GetById(id);
            if (vendedor != null)
            {
                _vendedores.Remove(vendedor);
                Console.WriteLine($"Vendedor {vendedor.Nome} removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Vendedor não encontrado.");
            }
        }

        public void Add(IVendedorRepository entity)
        {
            throw new NotImplementedException();
        }

        IVendedorRepository IVendedorRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IVendedorRepository> IVendedorRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(IVendedorRepository entity)
        {
            throw new NotImplementedException();
        }

        public VendedorEntity? ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VendedorEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public VendedorEntity? DeletarDados(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class VendedorService : IVendedorService
    {
        private readonly IVendedorRepository _vendedorRepository;

        public VendedorService(IVendedorRepository vendedorRepository)
        {
            _vendedorRepository = vendedorRepository;
        }

        public void Add(VendedorEntity entity)
        {
            _vendedorRepository.Add(entity);
        }

        public VendedorEntity GetById(int id)
        {
            return (VendedorEntity)_vendedorRepository.GetById(id);
        }

        public IEnumerable<VendedorEntity> GetAll()
        {
            return (IEnumerable<VendedorEntity>)_vendedorRepository.GetAll();
        }

        public void Update(VendedorEntity entity)
        {
            _vendedorRepository.Update(entity);
        }

        public void Delete(int id)
        {
            _vendedorRepository.Delete(id);
        }
    }
}
