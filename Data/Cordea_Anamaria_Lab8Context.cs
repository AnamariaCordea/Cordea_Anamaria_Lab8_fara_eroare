using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cordea_Anamaria_Lab8.Models;

namespace Cordea_Anamaria_Lab8.Data
{
    public class Cordea_Anamaria_Lab8Context : DbContext
    {
        public Cordea_Anamaria_Lab8Context (DbContextOptions<Cordea_Anamaria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cordea_Anamaria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Cordea_Anamaria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Cordea_Anamaria_Lab8.Models.Category> Category { get; set; }
    }
}
