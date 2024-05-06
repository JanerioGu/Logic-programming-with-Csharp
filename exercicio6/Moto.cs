/*6.	Implemente uma hierarquia de classes para representar diferentes tipos de veículos, como carros, motos e bicicletas. Cada classe deve herdar da classe base Veiculo. Adicione atributos específicos para cada tipo de veículo, como número de portas para carros, cilindrada para motos e número de marchas para bicicletas.*/

class Moto : Veiculo{
    public string modelo{get;set;}
    public int cilindrada{get;set;}

    public Moto(string modelo, int cilindrada, string cor, int ano){
        this.modelo = modelo;
        this.cilindrada = cilindrada;
        this.cor = cor;
        this.ano = ano;
    }

    public void exibirInfo(){
        System.Console.WriteLine("Modelo da MOTO: " + modelo);
        System.Console.WriteLine("Cilindrada: " + cilindrada);
        System.Console.WriteLine("Cor: " + this.cor);
        System.Console.WriteLine("Ano: " + this.ano);
    }


}