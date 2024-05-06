IReserva reservaRegular = new ReservaRegular();
reservaRegular.ReservarVoo("123", 2);
reservaRegular.CancelarReserva("123");
Console.WriteLine(reservaRegular.VerificarStatusReserva("123"));

IReserva reservaUpgrade = new ReservaUpgrade();
reservaUpgrade.ReservarVoo("456", 1);
reservaUpgrade.CancelarReserva("456");
Console.WriteLine(reservaUpgrade.VerificarStatusReserva("456"));

IReserva reservaGrupo = new ReservaGrupo();
reservaGrupo.ReservarVoo("789", 10);
reservaGrupo.CancelarReserva("789");
Console.WriteLine(reservaGrupo.VerificarStatusReserva("789"));