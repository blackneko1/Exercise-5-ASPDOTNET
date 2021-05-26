using Exercise_5_ASPDOTNET.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_5_ASPDOTNET.DataContext
{
    public class CrudDBContext : DbContext
    {
        public CrudDBContext(DbContextOptions options) : base(options)
        {
                
        }
        public DbSet<Register> Registers { get; set; }
    }
}
