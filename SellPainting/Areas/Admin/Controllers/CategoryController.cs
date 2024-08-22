using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SellPainting.Models;
using SellPainting.Repository;
using SellPainting.Repository.IRepository;

namespace SellPainting.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Category> CategoryList =  _unitOfWork.CategoryRepository.GetAll().ToList();
            return View(CategoryList);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CategoryRepository.Add(category);
                _unitOfWork.CategoryRepository.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id== null || id == 0)
            {
                return NotFound();
            }
            Category? category = _unitOfWork.CategoryRepository.Get(c => c.Id == id);   
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid) {
                _unitOfWork.CategoryRepository.Update(category);
                _unitOfWork.CategoryRepository.Save();
                TempData["success"] = "Category edited successfully";
                return RedirectToAction("Index");
            }
            return View();
        } 

        public IActionResult Delete(int? id)
        {
            if(id ==  null || id == 0)
            {
                return NotFound();
            }
            
            Category? category = _unitOfWork.CategoryRepository.Get(c=> c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            else
            {
                _unitOfWork.CategoryRepository.Delete(category);
                _unitOfWork.CategoryRepository.Save();
                TempData["success"] = "Delete category successfully";
                return RedirectToAction("Index");
            }
            
        }
    }
}
