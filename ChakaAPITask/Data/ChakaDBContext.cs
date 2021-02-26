using ChakaAPITask.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChakaAPITask.Data
{
    public class ChakaDBContext : DbContext
    {
        public ChakaDBContext(DbContextOptions<ChakaDBContext> options) : base(options)
        {
        }

        public DbSet<Stock> Stocks { get; set; }

    }
}
