using Modulo.Data;
using Modulo.Models;
using Modulo.Repository.Interfaces;

namespace Modulo.Repository.Repositorios
{
    public class ProyectosRepository : Repository<Proyectos>, IProyectosRepository
    {
        private readonly ApplicationDbContext _context;
        public ProyectosRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}