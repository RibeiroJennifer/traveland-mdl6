using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using traveland_api.Models;

namespace traveland_api.Context
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

            public DbSet<Usuarios> Usuarios {get; set; }
            public DbSet<Destinos> Destinos { get; set; }
            public DbSet<Compra> Compra { get; set; }
            public DbSet<Contato> Contato { get; set; }
        }

    }
