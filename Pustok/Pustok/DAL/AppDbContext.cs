using Microsoft.EntityFrameworkCore;
using Pustok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<DbContext>options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
