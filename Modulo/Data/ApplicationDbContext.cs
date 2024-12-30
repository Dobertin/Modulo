using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Modulo.Models;

namespace Modulo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Materiales> Materiales { get; set; }
        public DbSet<Partida> Partida { get; set; }
        public DbSet<Proyectos> Proyectos { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Aquí puedes agregar configuraciones adicionales, si las necesitas
        }
    }
}
