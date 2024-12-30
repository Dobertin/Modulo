using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Modulo.Models
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idusuario { get; set; }
        public string? email { get; set; }
        public string password { get; set; }
        public string? usuario { get; set; }
        public string? nombre { get; set; }
        public string? apellidos { get; set; }
        public int Idrol { get; set; }
        public string? telefono { get; set; }
        public string? pathfoto { get; set; }
        public string? UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }

        [ForeignKey(nameof(Idrol))]
        public Rol Rol { get; set; }
    }
}
