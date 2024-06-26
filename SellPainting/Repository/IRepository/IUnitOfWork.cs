namespace SellPainting.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ITypeOfPaintingRepository TypesRepository { get; }
        void Save();
    }
}
