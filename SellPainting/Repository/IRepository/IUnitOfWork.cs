namespace SellPainting.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IApplicationUserRepository ApplicationUserRepository { get; }
        void Save();
    }
}
