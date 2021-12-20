using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetocrud.Models
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options)
        {

        }

        public DbSet<Agencia> agencia { get; set; }


    }
}
