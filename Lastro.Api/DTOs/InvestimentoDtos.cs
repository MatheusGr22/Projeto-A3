using System.Text.Json;
using System.Text.Json.Serialization;
using Lastro.Api.Models;

namespace Lastro.Api.DTOs;

public class InvestimentoInputDto
{
    [JsonPropertyName("pessoaId")]
    public int PessoaId { get; set; }

    [JsonPropertyName("ativo")]
    public string Ativo { get; set; } = string.Empty;

    [JsonPropertyName("valorAplicado")]
    public decimal ValorAplicado { get; set; }

    [JsonPropertyName("taxaRendimento")]
    public decimal TaxaRendimento { get; set; }

    [JsonPropertyName("tipo")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TipoInvestimento Tipo { get; set; }
}

public class InvestimentoOutputDto
{
    public int Id { get; set; }
    public int PessoaId { get; set; }
    public string NomeTitular { get; set; } = string.Empty;
    public string Ativo { get; set; } = string.Empty;
    public decimal ValorAplicado { get; set; }
    public decimal TaxaRendimento { get; set; }
    public decimal RendimentoAnualEstimado => ValorAplicado * (TaxaRendimento / 100m);
    public DateTime DataAplicacao { get; set; }
    public string Tipo { get; set; } = string.Empty;
}