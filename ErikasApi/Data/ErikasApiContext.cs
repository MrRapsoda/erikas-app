using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ErikasApi.Models;

namespace ErikasApi.Data
{
    public class ErikasApiContext : DbContext
    {
        public ErikasApiContext (DbContextOptions<ErikasApiContext> options)
            : base(options)
        {
        }

        public DbSet<ErikasApi.Models.Vestido> Vestido { get; set; }

        public DbSet<ErikasApi.Models.Trajes2> Trajes2 { get; set; }

        public DbSet<ErikasApi.Models.VQuinceanos> VQuinceanos { get; set; }

        public DbSet<ErikasApi.Models.accesorioss> accesorioss { get; set; }
    }
}
