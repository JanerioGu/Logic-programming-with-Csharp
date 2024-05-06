class ex2SistemaRecebimento : receber {

    public void receber(int vlrReceber, int vlrCaixa){
        System.Console.WriteLine("Valor a receber eh: " + vlrReceber);
        System.Console.WriteLine("Valor em caixa após o pagamento eh: " +(vlrReceber + vlrCaixa));
    }
}