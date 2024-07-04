using SellPainting.Data;
using SellPainting.Models;
using SellPainting.Repository.IRepository;

namespace SellPainting.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        public ApplicationDbContext _db;
        public IApplicationUserRepository ApplicationUserRepository {  get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            ApplicationUserRepository =  new ApplicationUserRepository(db);
        }
        public void Save()
        {
           _db.SaveChanges();
        }
    }
}
