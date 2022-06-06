using System.ComponentModel.DataAnnotations;

namespace WebAPIBiblioteca.Entidades.Clases
{
    public class Editorial
    {
        public int EditorialId { get; set; }

        [Required]
        public string Nombre { get; set; }
    }
}
