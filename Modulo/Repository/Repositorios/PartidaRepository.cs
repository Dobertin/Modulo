using Modulo.Data;
using Modulo.Models;
using Modulo.Repository.Interfaces;

namespace Modulo.Repository.Repositorios
{
    public class PartidaRepository : Repository<Partida>, IPartidaRepository
    {
        private readonly ApplicationDbContext _context;

        public PartidaRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}