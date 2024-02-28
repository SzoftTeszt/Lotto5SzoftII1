using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto5Adat.Data
{
    public class LottoContext : DbContext
    {
        public LottoContext(DbContextOptions<LottoContext> options)
            : base(options)
        {
        }

        public LottoContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Lotto5API.Data;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Lotto5Adat.Models.LottoSzam> LottoSzam { get; set; } = default!;
    }
}