namespace Service_ticket.applications;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
   

}
