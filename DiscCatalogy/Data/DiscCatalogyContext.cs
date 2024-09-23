using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DiscCatalogy.Models
{
    public class DiscCatalogyContext : DbContext
    {
        public DiscCatalogyContext (DbContextOptions<DiscCatalogyContext> options)
            : base(options)
        {
        }

        public DbSet<DiscCatalogy.Models.MusicGenre> MusicGenre { get; set; } = default!;
    }
}
