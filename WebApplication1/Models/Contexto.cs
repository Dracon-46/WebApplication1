using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)  { 

        }

        public DbSet<Personagem> Personages { get; set; }
    }
}
