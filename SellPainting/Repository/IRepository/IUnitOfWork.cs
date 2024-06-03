namespace SellPainting.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ITypeOfPainting TypesRepository { get; }
        void Save();
    }
}
