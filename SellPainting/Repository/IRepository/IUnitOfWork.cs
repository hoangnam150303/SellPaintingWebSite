namespace SellPainting.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IApplicationUserRepository ApplicationUserRepository { get; }
        IPaintingRepository PaintingRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        void Save();
    }
}
