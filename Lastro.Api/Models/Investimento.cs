namespace Lastro.Api.Models;

public class Investimento
{
    public int Id { get; set; }
    public string Ativo { get; set; } = string.Empty;
    public decimal ValorAplicado { get; set; }
    public decimal TaxaRendimento { get; set; } // Em porcentagem ao ano (ex: 12.5)
    public DateTime DataAplicacao { get; set; } = DateTime.UtcNow;
    public TipoInvestimento Tipo { get; set; }
    
    public int PessoaId { get; set; }
    public Pessoa? Pessoa { get; set; }
}