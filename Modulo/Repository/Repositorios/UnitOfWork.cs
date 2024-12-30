using Microsoft.EntityFrameworkCore.Storage;
using Modulo.Data;
using Modulo.Repository.Interfaces;

namespace Modulo.Repository.Repositorios
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IDbContextTransaction _transaction;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Materiales = new MaterialesRepository(_context);
            Partida = new PartidaRepository(_context);
            Proyectos = new ProyectosRepository(_context);
            Rol = new RolRepository(_context);
            Usuarios = new UsuariosRepository(_context);
        }

        public IMaterialesRepository Materiales { get; private set; }
        public IPartidaRepository Partida { get; private set; }
        public IProyectosRepository Proyectos { get; private set; }
        public IRolRepository Rol { get; private set; }
        public IUsuariosRepository Usuarios { get; private set; }
        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }
        public async Task CommitTransactionAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                await _transaction.CommitAsync();
            }
            catch
            {
                await RollbackTransactionAsync();
                throw;
            }
        }
        public async Task RollbackTransactionAsync()
        {
            await _transaction.RollbackAsync();
        }
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
