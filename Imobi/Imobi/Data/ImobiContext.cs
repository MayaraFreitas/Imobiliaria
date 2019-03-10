using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Imobi.Models.ViewModels;
using Imobi.Models.ViewModels.Vistoria;

namespace Imobi.Models
{
    public class ImobiContext : DbContext
    {
        public ImobiContext (DbContextOptions<ImobiContext> options)
            : base(options)
        {
        }

        public DbSet<Imobi.Models.ViewModels.Teste> Teste { get; set; }
        public DbSet<Vistoria> Vistoria { get; set; }
        
    }
}
