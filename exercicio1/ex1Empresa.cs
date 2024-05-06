class ex1Empresa : ex1Funcionario{
    public string nome;

    public ex1Empresa(string nome, int salario, string cargo){
        this.nome = nome;
        this.cargo = cargo;
        this.salario = salario;
    }

    public void exibirInformacoes(){
        System.Console.WriteLine("Nome empresa: " + nome); 
        System.Console.WriteLine("Salario : " + salario);
        System.Console.WriteLine("Cargo : " + cargo);
    }
}

/*Explicando o funcionamento da HERANÇA.

Nada melhor que um exemplo pratico para demonstrar. 

Basicamente, o codigo demonstra que a classe ex1Empresa está trazendo pela forma de HERANCA da seguinte forma "ex1Empresa : ex1Funcionario" todas as informações que são de ordem public ou protect da classe mãe (ex1Funcionario) */