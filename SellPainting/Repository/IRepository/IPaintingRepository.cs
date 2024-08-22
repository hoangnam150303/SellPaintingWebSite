using SellPainting.Models;

namespace SellPainting.Repository.IRepository
{
    public interface IPaintingRepository:IRepository<Painting>
    {
        void Update(Painting entity);
    }
}
