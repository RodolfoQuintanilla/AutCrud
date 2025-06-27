

using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required, EmailAddress]
        public string Correo { get; set; }

        [Required]
        public string Contrasena { get; set; }
    }
}