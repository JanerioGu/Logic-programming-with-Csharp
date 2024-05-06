public class ReservaVooRegular : IReserva {
    public bool ReservarVoo(string numeroVoo, int assentos) {
        Console.WriteLine($"Reserva para {assentos} assentos no voo {numeroVoo} realizada com sucesso.");
        return true;
    }

    public bool CancelarReserva(string numeroVoo) {
        Console.WriteLine($"Reserva no voo {numeroVoo} cancelada.");
        return true;
    }

    public string VerificarStatusReserva(string numeroVoo) {
        return "Reserva ativa para o voo " + numeroVoo;
    }
}