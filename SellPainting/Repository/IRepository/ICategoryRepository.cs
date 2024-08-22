using SellPainting.Models;

namespace SellPainting.Repository.IRepository
{
    public interface ICategoryRepository:IRepository<Category>
    {
        void Update(Category entity);
    }
}
