/*6.	Implemente uma hierarquia de classes para representar diferentes tipos de veículos, como carros, motos e bicicletas. Cada classe deve herdar da classe base Veiculo. Adicione atributos específicos para cada tipo de veículo, como número de portas para carros, cilindrada para motos e número de marchas para bicicletas.*/

class Bicicleta : Veiculo{
    public string modelo{get;set;}
    public int numeroMarcha{get;set;}

    public Bicicleta(string modelo, int numeroMarcha, string cor, int ano){
        this.modelo = modelo;
        this.numeroMarcha = numeroMarcha;
        this.cor = cor;
        this.ano = ano;
    }

    public void exibirInfo(){
        System.Console.WriteLine("Modelo da BIKE: " + modelo);
        System.Console.WriteLine("numero de marchas: " + numeroMarcha);
        System.Console.WriteLine("Cor: " + this.cor);
        System.Console.WriteLine("Ano: " + this.ano);
    }


}