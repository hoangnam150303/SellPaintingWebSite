using Microsoft.AspNetCore.Mvc;
using SellPainting.Models;
using SellPainting.Repository.IRepository;

namespace SellPainting.Areas.Admin.Controllers
{
    public class TypePaintingOfSlideController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public TypePaintingOfSlideController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateType() 
        { 
            return View();  
        }
        [HttpPost]
        public IActionResult CreateType(IFormFile file,TypesOfPainting types)
        {
            if (types == null)
            {
                return NotFound();
            }
            string wwwrootPath = _webHostEnvironment.WebRootPath;
            if (ModelState.IsValid)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                string newsPath = Path.Combine(wwwrootPath, @"imgOfPainting");
                using (var fileStream = new FileStream(Path.Combine(newsPath, fileName), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                types.Img = @"\imgOfPainting" + fileName;
            }
                _unitOfWork.TypesRepository.Add(types);
             _unitOfWork.TypesRepository.Save();
            return RedirectToAction("Index");
        }
    }
}
