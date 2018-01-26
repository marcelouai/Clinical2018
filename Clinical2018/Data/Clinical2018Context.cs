using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Clinical2018.Models;

namespace Clinical2018.Models
{
    public class Clinical2018Context : DbContext
    {
        public Clinical2018Context (DbContextOptions<Clinical2018Context> options)
            : base(options)
        {
        }

        public DbSet<Clinical2018.Models.Pessoa> Pessoa { get; set; }

        public DbSet<Clinical2018.Models.Banco> Banco { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
    }
}
