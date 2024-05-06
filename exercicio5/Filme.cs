/*Implemente um sistema para uma locadora de filmes. Crie uma classe Filme
com os seguintes atributos: Titulo, Genero, Duracao, Disponivel (indicando se o
filme está disponível para locação). Implemente métodos para registrar a
locação de um filme, registrar a devolução de um filme e verificar se um filme
está disponível para locação. Não há necessidade de implementar rotinas de
bancos de dados.*/

class Filme{
    public string Titulo{get; set;}
    public string Genero{get; set;}
    public double Duracao{get; set;}
    public bool Disponivel{get; set;}

    public Filme(string Titulo, string Genero, double Duracao){
        this.Titulo = Titulo;
        this.Genero = Genero;
        this.Duracao = Duracao;
        Disponivel = true;
    }

    public void exibirInformacoes(){
        System.Console.WriteLine("Filme: " + this.Titulo);
        System.Console.WriteLine("Genero: " + this.Genero);
        System.Console.WriteLine("Duracao: " + this.Duracao);

    }

    public void registrarLocacao(Boolean Disponível){
        if(Disponivel){
            Disponivel = false;
            System.Console.WriteLine("Filme " + this.Titulo + " locado com sucesso.");
        }
    }
    public void registrarDevolucao(Boolean Disponivel){
        if(!Disponivel){
            Disponivel = true;
            System.Console.WriteLine("Filme " + this.Titulo + " devolvido com sucesso");
        }
    }
}
