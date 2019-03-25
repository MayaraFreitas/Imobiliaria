using Imobi.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imobi.Models
{
    public class ImobiContext : DbContext
    {
        public ImobiContext (DbContextOptions<ImobiContext> options)
            : base(options)
        {
        }

        public DbSet<Vistoria> Vistoria { get; set; }
        public DbSet<User> Accounts { get; set; }
        
    }
}
