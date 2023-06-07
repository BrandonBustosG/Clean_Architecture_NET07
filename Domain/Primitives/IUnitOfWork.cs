namespace Domain.Primitives;


public interface IUnitOfWork
{
    Task<int> SaveChanesAsync(CancellationToken cancellationToken = default);
}
