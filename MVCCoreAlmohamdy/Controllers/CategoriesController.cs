using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCCoreAlmohamdy.Models;
using MVCCoreAlmohamdy.Repositry.Base;

namespace MVCCoreAlmohamdy.Controllers
{
    [Authorize(Roles = clsRoles.User)]
    public class CategoriesController : Controller
    {
        //private readonly IRepositry<Category> _repositry;

        //public CategoriesController(IRepositry<Category> repositry)
        //{
        //    _repositry = repositry;
        //}
        private readonly IUnitOfWork _unitOfWork;

        public CategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var oneCat = _unitOfWork.category.SelectOne(x => x.Name == "Computers");
            var allCat = await _unitOfWork.category.FindAllAsync("Items");

            return View(_unitOfWork.category.FindAll());
            //var oneCat = _repositry.SelectOne(x => x.Name == "Computers");
            //var allCat = await _repositry.FindAllAsync("Items");

            //return View(_repositry.FindAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                //_repositry.AddOne(category);
                if (category.FormFile != null)
                {
                    MemoryStream ms = new MemoryStream();
                    category.FormFile.CopyTo(ms);
                    category.CatImage = ms.ToArray();
                }
                _unitOfWork.category.AddOne(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //var category = _repositry.FindById(id.Value);
            var category = _unitOfWork.category.FindById(id.Value);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                //_repositry.UpdateOne(category);
                _unitOfWork.category.UpdateOne(category);
                TempData["SuccessfullData"] = "Category has been updated succesfully";
                return RedirectToAction("Index");
            }
            return View(category);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var category = _unitOfWork.category.FindById(id.Value);
            //var category = _repositry.FindById(id.Value);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult DeleteItem(Category category)
        {
            try
            {
                //_repositry.DeleteOne(category);
                _unitOfWork.category.DeleteOne(category);
                TempData["SuccessfullData"] = "Category has been removed succesfully";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(category);
            }



        }
        public IActionResult Details(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var category = _unitOfWork.category.FindById(id.Value);
            //var category = _repositry.FindById(id.Value);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

    }
}
