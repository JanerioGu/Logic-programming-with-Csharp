/*6.	Implemente uma hierarquia de classes para representar diferentes tipos de veículos, como carros, motos e bicicletas. Cada classe deve herdar da classe base Veiculo. Adicione atributos específicos para cada tipo de veículo, como número de portas para carros, cilindrada para motos e número de marchas para bicicletas.*/

class Carro : Veiculo{
    public string modelo{get;set;}
    public int numeroPortas{get;set;}

    public Carro(string modelo, int numeroPortas, string cor, int ano){
        this.modelo = modelo;
        this.numeroPortas = numeroPortas;
        this.cor = cor;
        this.ano = ano;
    }

    public void exibirInfo(){
        System.Console.WriteLine("Modelo do carro: " + modelo);
        System.Console.WriteLine("numero de portas: " + numeroPortas);
        System.Console.WriteLine("Cor: " + this.cor);
        System.Console.WriteLine("Ano: " + this.ano);
    }


}