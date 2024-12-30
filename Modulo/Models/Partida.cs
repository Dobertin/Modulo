using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Modulo.Models
{
    public class Partida
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idpartida { get; set; }
        public int idproyecto { get; set; }
        public string? descripcion { get; set; }
        public DateTime fecha { get; set; }
        public string? unidad { get; set; }
        public int metradototal { get; set; }
        public int metradosaldo { get; set; }
        public decimal valorizacionsaldo { get; set; }
        public decimal porvalorizacion { get; set; }
        public decimal porsaldo { get; set; }
        public string? observacion { get; set; }
        public DateTime mes { get; set; }
        public string? UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }

        [ForeignKey(nameof(idproyecto))]
        public Proyectos proyectos { get; set; }
    }
        
}
