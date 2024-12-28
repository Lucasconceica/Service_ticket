namespace Service_ticket.applications;

public class TabelasTickets
{
    public int Id { get; set; }
    public string Assunto { get; set; }
    public string Mensagem { get; set; }
    public string Status { get; set; }
    public DateTime DataCriacao { get; set; }
}
