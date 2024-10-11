using CP2.Domain.Entities;
using CP2.Domain.Interfaces.Dtos;

namespace CP2.Domain.Interfaces
{
    public interface IFornecedorApplicationService
    {
        object DeletarDadosFornecedor(int id);
        object EditarDadosFornecedor(int id, CP2.Application.Dtos.FornecedorDto entity);
        object ObterFornecedorPorId(int id);
        object ObterTodosFornecedores();
        object SalvarDadosFornecedor(CP2.Application.Dtos.FornecedorDto entity);
    }
}
