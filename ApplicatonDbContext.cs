using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebAPIBiblioteca.Entidades.Clases;
using WebAPIBiblioteca.Entidades.Seed;

namespace WebAPIBiblioteca
{
    public class ApplicatonDbContext: DbContext
    {
        public ApplicatonDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Libro>().HasKey(x => x.LibroId);
            modelBuilder.Entity<Libro>().Property(x => x.Título).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<Libro>().Property(x => x.Páginas).HasPrecision(precision: 1, scale: 1000);

            modelBuilder.Entity<Editorial>().HasKey(x => x.EditorialId);
            modelBuilder.Entity<Editorial>().Property(x => x.Nombre).HasMaxLength(50).IsRequired();


            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeedData.Seed(modelBuilder);
        }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
    }
}
