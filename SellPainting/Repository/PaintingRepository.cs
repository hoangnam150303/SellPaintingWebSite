using SellPainting.Data;
using SellPainting.Models;
using SellPainting.Repository.IRepository;

namespace SellPainting.Repository
{
    public class PaintingRepository : Repository<Painting>, IPaintingRepository
    {
        private readonly ApplicationDbContext _db;
        public PaintingRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Painting entity)
        {
           _db.Paintings.Update(entity);
        }
    }
}
