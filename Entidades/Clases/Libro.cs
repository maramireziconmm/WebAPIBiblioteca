using System.ComponentModel.DataAnnotations;

namespace WebAPIBiblioteca.Entidades.Clases
{
    public class Libro
    {
        public int LibroId { get; set; }
        [Required]
        public string Título { get; set; }

        public int Páginas { get; set; }

        public int EditorialIdentificador { get; set; }
        public Editorial Editorial { get; set; }

    }
}
