/*7.	Desenvolva um sistema de gerenciamento de contas bancárias com diferentes tipos de contas, como conta corrente, conta poupança e conta empresarial. Utilize herança para representar a relação entre as classes de contas e implemente métodos específicos para cada tipo de conta, como calcular juros para contas poupança e verificar saldo mínimo para contas empresariais.*/

class ContaPoupanca{
    public string nomeUsuario{get;set;}
    public int numeroConta{get;set;}
    public int saldo{get;set;}
    public Boolean statusConta{get;set;}

    public ContaPoupanca(string nomeUsuario, int numeroConta, int saldo){
        this.nomeUsuario = nomeUsuario;
        this.numeroConta = numeroConta;
        this.saldo = saldo;
        this.statusConta = false;
    }   

    public void abrirConta(Boolean statusConta){
        if(saldo <= 200){
            System.Console.WriteLine("saldo insuficiente para abertura de conta");
        }
        if(statusConta == true || saldo >= 200){
            System.Console.WriteLine("Conta aberta com sucesso");
        }
    }

    public void fecharConta(Boolean statusConta){
        if(statusConta == false){
            System.Console.WriteLine("conta fechada com sucesso");
        }
    }

    public void adicionarSaldo(int valor){
        saldo += valor;
    }

    public void exibirInfo(){
        System.Console.WriteLine("Nome : " + nomeUsuario);
        System.Console.WriteLine("numero conta : " + numeroConta);
        System.Console.WriteLine("saldo : " + saldo);
    }

    public void calcJuros(int valorJuros){
        valorJuros = saldo * (valorJuros /100);
    }

}