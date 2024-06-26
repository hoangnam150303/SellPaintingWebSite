using SellPainting.Models;

namespace SellPainting.Repository.IRepository
{
    public interface ITypeOfPaintingRepository:IRepository<TypesOfPainting>
    {
        void Update(TypesOfPainting entity);
    }
}
