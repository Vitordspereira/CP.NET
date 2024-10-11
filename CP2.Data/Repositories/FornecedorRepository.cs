using CP2.Data.AppData;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;

namespace CP2.Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly List<FornecedorEntity> _fornecedores = new List<FornecedorEntity>();

        public void Add(FornecedorEntity entity)
        {
            _fornecedores.Add(entity);
            Console.WriteLine($"Fornecedor {entity.Nome} adicionado com sucesso.");
        }

        public FornecedorEntity GetById(int id)
        {
            return _fornecedores.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<FornecedorEntity> GetAll()
        {
            return _fornecedores;
        }

        public void Update(FornecedorEntity entity)
        {
            var fornecedor = GetById(entity.Id);
            if (fornecedor != null)
            {
                fornecedor.Nome = entity.Nome;
                fornecedor.CNPJ = entity.CNPJ;
                fornecedor.Endereco = entity.Endereco;
                fornecedor.Telefone = entity.Telefone;
                fornecedor.Email = entity.Email;
                fornecedor.CriadoEm = entity.CriadoEm;
                Console.WriteLine($"Fornecedor {fornecedor.Nome} atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Fornecedor não encontrado.");
            }
        }

        public void Delete(int id)
        {
            var fornecedor = GetById(id);
            if (fornecedor != null)
            {
                _fornecedores.Remove(fornecedor);
                Console.WriteLine($"Fornecedor {fornecedor.Nome} removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Fornecedor não encontrado.");
            }
        }

        public void Add(IFornecedorRepository entity)
        {
            throw new NotImplementedException();
        }

        IFornecedorRepository IFornecedorRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IFornecedorRepository> IFornecedorRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(IFornecedorRepository entity)
        {
            throw new NotImplementedException();
        }
    }
}
