using Modulo.Data;
using Modulo.Models;
using Modulo.Repository.Interfaces;

namespace Modulo.Repository.Repositorios
{
    public class RolRepository : Repository<Rol>, IRolRepository
    {
        private readonly ApplicationDbContext _context;
        public RolRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}