public class ReservaVooComUpgrade : IReserva {
    public bool ReservarVoo(string numeroVoo, int assentos) {
        Console.WriteLine($"Reserva para {assentos} assentos no voo {numeroVoo} com upgrade de classe realizada com sucesso.");
        return true;
    }

    public bool CancelarReserva(string numeroVoo) {
        Console.WriteLine($"Reserva no voo {numeroVoo} com upgrade de classe cancelada.");
        return true;
    }

    public string VerificarStatusReserva(string numeroVoo) {
        return "Reserva com upgrade de classe ativa para o voo " + numeroVoo;
    }
}