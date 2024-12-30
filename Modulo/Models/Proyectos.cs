using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Modulo.Models
{
    public class Proyectos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idproyecto { get; set; }
        public string? Nombre { get; set; }
        public string? Region { get; set; }
        public DateTime Fechainicio { get; set; }
        public DateTime Fechafin { get; set; }
        public decimal Presupuesto { get; set; }
        public int Idresponsable { get; set; }
        public string? UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }

        [ForeignKey(nameof(Idresponsable))]
        public Usuarios Usuario { get; set; }
    }
}
