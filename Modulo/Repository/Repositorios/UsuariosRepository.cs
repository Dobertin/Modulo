using Modulo.Data;
using Modulo.Models;
using Modulo.Repository.Interfaces;

namespace Modulo.Repository.Repositorios
{
    public class UsuariosRepository :Repository<Usuarios>, IUsuariosRepository
    {
        private readonly ApplicationDbContext _context;
        public UsuariosRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
