using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSeans.Models
{
    public class sinemaContext:DbContext
    {
        public DbSet<Salonlar> Salonlar { get; set; }
        public DbSet<Filmler> Filmler { get; set; }
        public DbSet<Seanslar> Seanslar { get; set; }
    }
}
