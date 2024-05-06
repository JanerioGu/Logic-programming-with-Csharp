
public class produto{
    public string Nome{get; set;}
    public int Preco{get; set;}
    public int QuantidadeEmEstoque{get; set;}

    public produto(string nome, int preco, int quantidadeEmEstoque){
        Nome = nome;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void exibirInformacoes(){
        System.Console.WriteLine("Nome do produto: " + Nome);
        System.Console.WriteLine("Preco do produto: " + Preco);
        System.Console.WriteLine("Quantidade em estoque: " + QuantidadeEmEstoque);
    }

    public void removerEstoque(int qtdRemover){
        System.Console.WriteLine("Nova quantidade em estoque: " + (QuantidadeEmEstoque - qtdRemover));
    }

    public void calcularValorEstoque(){
        System.Console.WriteLine("O valor total em produtos no estoque é: " + (QuantidadeEmEstoque * Preco));
    }
}