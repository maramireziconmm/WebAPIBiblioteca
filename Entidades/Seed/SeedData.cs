using Microsoft.EntityFrameworkCore;
using WebAPIBiblioteca.Entidades.Clases;

namespace WebAPIBiblioteca.Entidades.Seed
{
    public class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            // Editoriales
            var Editorial1 = new Editorial { EditorialId = 1, Nombre = "Planeta"};
            var Editorial2 = new Editorial { EditorialId = 2, Nombre = "Aguilar" };
           

            modelBuilder.Entity<Editorial>().HasData(Editorial1, Editorial2);

            // Libros
            var Libro1 = new Libro { LibroId = 1, Título = "El Quijote", Páginas= 300, EditorialIdentificador = Editorial1.EditorialId };
            var Libro2 = new Libro { LibroId = 2, Título = "Cien años de soledad", Páginas = 350, EditorialIdentificador = Editorial1.EditorialId };
            var Libro3 = new Libro { LibroId = 3, Título = "El amor en los tiempos del cólera", Páginas = 500, EditorialIdentificador = Editorial2.EditorialId };
            var Libro4= new Libro { LibroId = 4, Título = "Divina comedia", Páginas = 300, EditorialIdentificador = Editorial1.EditorialId };
            var Libro5 = new Libro { LibroId = 5, Título = "El extranjero", Páginas = 350, EditorialIdentificador = Editorial1.EditorialId };
            var Libro6 = new Libro { LibroId = 6, Título = "Crimen y castigo", Páginas = 1000, EditorialIdentificador = Editorial2.EditorialId };
            var Libro7 = new Libro { LibroId = 7, Título = "El hombre invisible", Páginas = 1500, EditorialIdentificador = Editorial1.EditorialId };
            var Libro8 = new Libro { LibroId = 8, Título = "Almas muertas", Páginas = 850, EditorialIdentificador = Editorial1.EditorialId };
            var Libro9 = new Libro { LibroId = 9, Título = "El castillo", Páginas = 900, EditorialIdentificador = Editorial2.EditorialId };
            var Libro10 = new Libro { LibroId = 10, Título = "Pippi Calzaslargas", Páginas = 800, EditorialIdentificador = Editorial2.EditorialId };

            modelBuilder.Entity<Libro>().HasData(Libro1, Libro2, Libro3, Libro4, Libro5, Libro6, Libro7, Libro8, Libro9, Libro10);

        }
    }
}
