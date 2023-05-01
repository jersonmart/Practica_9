using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Identity.Client;
using Practica_9.Models;

namespace Practica_9.Models
{
    public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<equipos> equipos { get; set; }
        public DbSet<marcas> marcas { get; set; }

    }
}
