public class PagamentoBoleto : IMetodoPagamento {
    private string codigoBoleto;

    public PagamentoBoleto(string codigoBoleto) {
        this.codigoBoleto = codigoBoleto;
    }

    public bool RealizarPagamento(double valor) {
        Console.WriteLine($"Pagamento de R${valor} autorizado com o boleto.");
        return true;
    }

    public string VerificarStatusPagamento() {
        return "Boleto bancário pago";
    }
}