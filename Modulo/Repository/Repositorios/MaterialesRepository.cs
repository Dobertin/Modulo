using Modulo.Data;
using Modulo.Models;
using Modulo.Repository.Interfaces;

namespace Modulo.Repository.Repositorios
{
    public class MaterialesRepository : Repository<Materiales>, IMaterialesRepository
    {
        private readonly ApplicationDbContext _context;

        public MaterialesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
