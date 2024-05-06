public class ReservaVooParaGrupos : IReserva {
    public bool ReservarVoo(string numeroVoo, int assentos) {
        Console.WriteLine($"Reserva para um grupo de {assentos} assentos no voo {numeroVoo} realizada com sucesso.");
        return true;
    }

    public bool CancelarReserva(string numeroVoo) {
        Console.WriteLine($"Reserva no voo {numeroVoo} para grupo grande cancelada.");
        return true;
    }

    public string VerificarStatusReserva(string numeroVoo) {
        return "Reserva para grupo grande ativa para o voo " + numeroVoo;
    }
}