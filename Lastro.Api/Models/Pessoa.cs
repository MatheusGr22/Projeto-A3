namespace Lastro.Api.Models;

public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public List<Investimento> Investimentos { get; set; } = new();
}