using SellPainting.Data;
using SellPainting.Models;
using SellPainting.Repository.IRepository;

namespace SellPainting.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        public ApplicationDbContext _db;
        public ITypeOfPaintingRepository TypesRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            TypesRepository = new TypesRepository(db);

        }
        public void Save()
        {
           _db.SaveChanges();
        }
    }
}
