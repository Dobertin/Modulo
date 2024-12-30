using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Modulo.Models
{
    public class Materiales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idmateriales { get; set; }
        public int Idpartida { get; set; }
        public string? descripcion { get; set; }
        public string? largo { get; set; }
        public string? ancho { get; set; }
        public string? altura { get; set; }
        public int nrocarasveces { get; set; }
        public int nropegas { get; set; }
        public int longitud { get; set; }
        public string? longitudtotal { get; set; }
        public string? omega { get; set; }
        public DateTime Fechacorrecion { get; set; }
        public string? incidencia { get; set; }
        public decimal totalarea { get; set; }
        public decimal totalvolumen { get; set; }
        public decimal totalpeso { get; set; }
        public string? UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }

        [ForeignKey(nameof(Idpartida))]
        public Partida partida { get; set; }
    }
}
