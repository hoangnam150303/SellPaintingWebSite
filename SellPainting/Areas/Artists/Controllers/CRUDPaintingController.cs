using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SellPainting.Models;
using SellPainting.Models.ViewModels;
using SellPainting.Repository.IRepository;

namespace SellPainting.Areas.Artists.Controllers
{
    [Area("Artists")]
    [Authorize(Roles = "Artists")]
    public class CRUDPaintingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public CRUDPaintingController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, UserManager<ApplicationUser> userManager) {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            List<Painting> paintingOfArtist = _unitOfWork.PaintingRepository.GetAll().ToList();
            return View(paintingOfArtist);
        }

        public IActionResult Create() {

            SellPaintingVM vm = new SellPaintingVM
            {
                Categories = _unitOfWork.CategoryRepository.GetAll().Select(c => new SelectListItem()
                {
                    Text = c.Name,
                    Value = c.Id.ToString(),
                })
            };
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Create(IFormFile? file, SellPaintingVM paintingVM) { 
            string wwwrootPath = _webHostEnvironment.WebRootPath;

            if(ModelState.IsValid ) {
                string pictureName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                string newsPath = Path.Combine(wwwrootPath, @"File\Painting");
                using(var fileStream = new FileStream(Path.Combine(newsPath,pictureName), FileMode.Create)) 
                { 
                    file.CopyTo(fileStream);    
                }
                paintingVM.Painting.PictureUrl = @"\File\Painting" + pictureName;

                var currentArtists = await _userManager.GetUserAsync(User);
                if(currentArtists != null)
                {
                    paintingVM.Painting.IdArtists = currentArtists.Id;
                    paintingVM.Painting.Valid = false;
                    _unitOfWork.PaintingRepository.Add(paintingVM.Painting);
                    _unitOfWork.PaintingRepository.Save();
                    TempData["success"] = "Create request upload painting success!";
                    return RedirectToAction("Index");
                }
            else
                {
					TempData["error"] = "Create request upload painting fail!";
                    return RedirectToAction("Index");
				}
            }
            return View(paintingVM);
        }

        
    }
}
