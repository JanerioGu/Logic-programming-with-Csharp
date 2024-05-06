class ex2SistemaPagamento : pagar{
    
    public void pagar(int vlrPagar, int vlrCaixa){
        System.Console.WriteLine("Valor a pagar eh: " + vlrPagar);
        System.Console.WriteLine("Valor em caixa após o pagamento eh: " +(vlrCaixa - vlrPagar));
    }
}