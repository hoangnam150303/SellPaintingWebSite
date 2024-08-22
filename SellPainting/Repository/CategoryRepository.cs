using SellPainting.Data;
using SellPainting.Models;
using SellPainting.Repository.IRepository;

namespace SellPainting.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category entity)
        {
            _db.Categories.Update(entity);
        }
    }
}
