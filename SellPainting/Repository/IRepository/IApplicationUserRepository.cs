
using SellPainting.Models;

namespace SellPainting.Repository.IRepository
{
    public interface IApplicationUserRepository:IRepository<ApplicationUser>
    {
        void Update(ApplicationUser entity);
    }
}
