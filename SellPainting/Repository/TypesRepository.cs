using SellPainting.Data;
using SellPainting.Models;
using SellPainting.Repository.IRepository;

namespace SellPainting.Repository
{
    public class TypesRepository:Repository<TypesOfPainting>,ITypeOfPainting
    {
        private readonly ApplicationDbContext _db;
        public TypesRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(TypesOfPainting category)
        {
            _db.TypesOfPaitings.Update(category);
        }

    }
}
