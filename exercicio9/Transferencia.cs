
public class Transferencia : IMetodoPagamento {
    private string numeroContaOrigem;
    private string numeroContaDestino;

    public Transferencia(string numeroContaOrigem, string numeroContaDestino) {
        this.numeroContaOrigem = numeroContaOrigem;
        this.numeroContaDestino = numeroContaDestino;
    }

    public bool RealizarPagamento(double valor) {
        Console.WriteLine($"Transferência bancária de R${valor} realizada da conta {numeroContaOrigem} para a conta {numeroContaDestino}.");
        return true;
    }

    public string VerificarStatusPagamento() {
        return "Transferência bancária concluída";
    }
}
