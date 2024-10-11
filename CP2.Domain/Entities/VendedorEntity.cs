using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.Domain.Entities
{
    [Table("tb_vendedor")]
    public class VendedorEntity
    {
        public int Id { get; set; }                  // Identificador único do vendedor
        public string Nome { get; set; }             // Nome do vendedor
        public string Email { get; set; }            // Email do vendedor
        public string Telefone { get; set; }         // Telefone de contato do vendedor
        public DateTime DataNascimento { get; set; } // Data de nascimento do vendedor
        public string Endereco { get; set; }         // Endereço do vendedor
        public DateTime DataContratacao { get; set; } // Data de contratação do vendedor
        public decimal ComissaoPercentual { get; set; } // Percentual de comissão do vendedor
        public decimal MetaMensal { get; set; }      // Meta mensal do vendedor
        public DateTime CriadoEm { get; set; }       // Data de criação do registro

        // Construtor para inicializar um novo vendedor
        public VendedorEntity(int id, string nome, string email, string telefone, DateTime dataNascimento, string endereco, DateTime dataContratacao, decimal comissaoPercentual, decimal metaMensal)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            DataContratacao = dataContratacao;
            ComissaoPercentual = comissaoPercentual;
            MetaMensal = metaMensal;
            CriadoEm = DateTime.Now; // Define a data de criação como o momento atual
        }

        // Método para exibir dados do vendedor
        public void ExibirVendedor()
        {
            Console.WriteLine($"ID: {Id}, Nome: {Nome}, Email: {Email}, Telefone: {Telefone}, Data de Nascimento: {DataNascimento.ToShortDateString()}, Endereço: {Endereco}, Data de Contratação: {DataContratacao.ToShortDateString()}, Comissão: {ComissaoPercentual}%, Meta Mensal: {MetaMensal}, Criado Em: {CriadoEm}");
        }
    }
}
