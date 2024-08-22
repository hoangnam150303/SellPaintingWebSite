using SellPainting.Data;
using SellPainting.Models;
using SellPainting.Repository.IRepository;

namespace SellPainting.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        public ApplicationDbContext _db;
        public IApplicationUserRepository ApplicationUserRepository {  get; private set; }

        public IPaintingRepository PaintingRepository { get; private set;}
        public ICategoryRepository CategoryRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            ApplicationUserRepository =  new ApplicationUserRepository(db);
            PaintingRepository = new PaintingRepository(db);
            CategoryRepository = new CategoryRepository(db);
        }
        public void Save()
        {
           _db.SaveChanges();
        }
    }
}
