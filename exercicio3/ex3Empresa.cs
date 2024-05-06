class ex3Empresa : ex3Funcionario{
    public string nome;

    public ex3Empresa(string nome, int salario, string cargo){
        this.nome = nome;
        this.cargo = cargo;
        this.salario = salario;
    }

    public override void exibirInformacoes(){
        System.Console.WriteLine("Nome empresa: " + nome); 
        base.exibirInformacoes();
    }

    public void aumentarSalario(int aumento){
        System.Console.WriteLine("Salario após aumento é: " + (salario+aumento));
    }

    public void aumentarSalario(int aumento, int bonus){
        System.Console.WriteLine("Salario após aumento e o adicional do bonus é: " + (salario + aumento + bonus));
    }

    //Meu metodo aumentarSalario está com sobrecarga. No exemplo usei o mesmo método usando parametros diferentes para dar resultados diferentes também, caracterizando a sobrecarga do metodo.

    //Detalhe no metodo EXIBIRIFORMAÇÕES o "override" sobrescreve o metodo EXIBIRINFORMAÇÕES da classe mãe, trazendo outras informações para o metodo.
    
}
