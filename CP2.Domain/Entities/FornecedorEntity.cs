using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.Domain.Entities
{
    [Table("tb_fornecedor")]
    public class FornecedorEntity
    {
         public int Id { get; set; }                  // Identificador único do fornecedor
         public string Nome { get; set; }             // Nome do fornecedor
         public string CNPJ { get; set; }             // CNPJ do fornecedor
         public string Endereco { get; set; }         // Endereço do fornecedor
         public string Telefone { get; set; }         // Telefone de contato do fornecedor
         public string Email { get; set; }            // Email do fornecedor
         public DateTime CriadoEm { get; set; }       // Data de criação do registro

          // Construtor para inicializar um novo fornecedor
          public FornecedorEntity(int id, string nome, string cnpj, string endereco, string telefone, string email)
          {
             Id = id;
             Nome = nome;
             CNPJ = cnpj;
             Endereco = endereco;
             Telefone = telefone;
             Email = email;
             CriadoEm = DateTime.Now; // Define a data de criação como o momento atual
          }

          // Método para exibir dados do fornecedor
          public void ExibirFornecedor()
          {
                Console.WriteLine($"ID: {Id}, Nome: {Nome}, CNPJ: {CNPJ}, Endereço: {Endereco}, Telefone: {Telefone}, Email: {Email}, Criado Em: {CriadoEm}");
          }
    }

}
