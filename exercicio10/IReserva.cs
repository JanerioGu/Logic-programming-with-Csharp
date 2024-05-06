public interface IReserva {
    bool ReservarVoo(string numeroVoo, int assentos);
    bool CancelarReserva(string numeroVoo);
    string VerificarStatusReserva(string numeroVoo);
}