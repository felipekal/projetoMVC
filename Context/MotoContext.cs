using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;

namespace ProjetoMVC.Context
{
    public class MotoContext : DbContext
    {
        public MotoContext(DbContextOptions<MotoContext> options) : base(options)
        {

        }

        public DbSet<Moto> Motos {get; set;}
    }
}