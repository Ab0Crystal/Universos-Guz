public class Reserva
{
    public int Id { get; set; }
    public string Usuario { get; set; }
    public int EventoId { get; set; }

    public Evento Evento { get; set; }
}
