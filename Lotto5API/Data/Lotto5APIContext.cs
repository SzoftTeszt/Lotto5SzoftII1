using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lotto5Adat.Models;

namespace Lotto5API.Data
{
    public class Lotto5APIContext : DbContext
    {
        public Lotto5APIContext (DbContextOptions<Lotto5APIContext> options)
            : base(options)
        {
        }

        public DbSet<Lotto5Adat.Models.LottoSzam> LottoSzam { get; set; } = default!;
    }
}
