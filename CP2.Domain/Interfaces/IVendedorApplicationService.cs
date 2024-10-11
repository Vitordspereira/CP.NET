using CP2.Domain.Entities;
using CP2.Domain.Interfaces.Dtos;

namespace CP2.Domain.Interfaces
{
    public interface IVendedorApplicationService
    {
        object DeletarDadosVendedor(int id);
        object EditarDadosVendedor(int id, CP2.Application.Dtos.VendedorDto entity);
        object ObterTodosVendedores();
        object ObterVendedorPorId(int id);
        object SalvarDadosVendedor(CP2.Application.Dtos.VendedorDto entity);
    }
}
