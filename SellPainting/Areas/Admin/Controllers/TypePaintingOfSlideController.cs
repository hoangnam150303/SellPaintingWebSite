using Microsoft.AspNetCore.Mvc;
using SellPainting.Repository.IRepository;

namespace SellPainting.Areas.Admin.Controllers
{
    public class TypePaintingOfSlideController : Controller
       
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateType() 
        { 
        return View();  
        }
        [HttpPost]
        public IActionResult CreateType()
        {
            return View();
        }
    }
}
