namespace SimpleTransferPlatform.Domain.Interfaces
{
    internal interface IUnitOfWork
    {
        Task Commit(CancellationToken cancellationToken);
    }
}
