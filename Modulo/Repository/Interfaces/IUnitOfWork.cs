namespace Modulo.Repository.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IMaterialesRepository Materiales { get; }
        IPartidaRepository Partida { get; }
        IProyectosRepository Proyectos { get; }
        IRolRepository Rol { get; }
        IUsuariosRepository Usuarios { get; }
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
        Task<int> CompleteAsync();
        Task<int> SaveChangesAsync();
    }
}
