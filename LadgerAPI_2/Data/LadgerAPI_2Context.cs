using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LadgerAPI_2.Models;

namespace LadgerAPI_2.Data
{
    public class LadgerAPI_2Context : DbContext
    {
        public LadgerAPI_2Context (DbContextOptions<LadgerAPI_2Context> options)
            : base(options)
        {
        }

        public DbSet<LadgerAPI_2.Models.User> User { get; set; } = default!;
        public DbSet<LadgerAPI_2.Models.Ladger> Ladger { get; set; } = default!;
        public DbSet<LadgerAPI_2.Models.Transaction> Transaction { get; set; } = default!;
    }
}
