public class Cartao : IMetodoPagamento {
    public string numeroCartao;
    public string dataValidade;
    public string codigoSeguranca;

    public PagamentoCartaoCredito(string numeroCartao, string dataValidade, string codigoSeguranca) {
        this.numeroCartao = numeroCartao;
        this.dataValidade = dataValidade;
        this.codigoSeguranca = codigoSeguranca;
    }

    public bool RealizarPagamento(double valor) {
        Console.WriteLine($"Pagamento de R${valor} autorizado com cartão de crédito.");
        return true;
    }

    public string VerificarStatusPagamento() {
        return "Pagamento com cartão de crédito autorizado";
    }
}