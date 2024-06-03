using SellPainting.Models;

namespace SellPainting.Repository.IRepository
{
    public interface ITypeOfPainting:IRepository<TypesOfPainting>
    {
        void Update(TypesOfPainting entity);
    }
}
