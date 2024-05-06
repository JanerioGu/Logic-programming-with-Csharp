class ex3Funcionario{
    public int salario;
    public string cargo;

    public virtual void exibirInformacoes(){
        System.Console.WriteLine("Salario : " + salario);
        System.Console.WriteLine("Cargo : " + cargo);
    }

}