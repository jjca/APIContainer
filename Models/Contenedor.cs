using System.ComponentModel.DataAnnotations;

namespace APIContainers.Models
{
    public class Contenedor
    {
        [Key]
        public int Id { get; set; }
        public string Estatus { get; set; } = string.Empty;
        public string Naviera { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty; // Nuevo campo para el código
    }
}
