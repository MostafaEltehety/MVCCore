using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCCoreAlmohamdy.Data;
using MVCCoreAlmohamdy.Models;

namespace MVCCoreAlmohamdy.Controllers
{
    //[Authorize(Roles = clsRoles.Admin)]
    [Authorize]
    public class ItemsController : Controller
    {
        private readonly MyAppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ItemsController(MyAppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> items = _context.Items.Include(c => c.Category).ToList();
            return View(items);
        }
        public IActionResult New()
        {
            CreateSelectList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult New(Item item)
        {
            if (ModelState.IsValid)
            {
                if (item.Name == "100")
                {
                    ModelState.AddModelError("Name", "Name can not equal 100");
                    return View(item);
                }
                if (item.FormFile != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(item.FormFile.FileName);
                    string path = Path.Combine(_webHostEnvironment.WebRootPath, "Upload", "Images", fileName);
                    item.FormFile.CopyTo(new FileStream(path, FileMode.Create));
                    item.ImgPath = fileName;
                }
                _context.Items.Add(item);
                _context.SaveChanges();
                TempData["SuccessfullData"] = "Item has been added succesfully";
                return RedirectToAction("Index");
            }
            return View(item);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var item = _context.Items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            CreateSelectList(item.Id);
            return View(item);
        }
        [HttpPut]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Item item)
        {
            if (ModelState.IsValid)
            {
                if (item.Name == "100")
                {
                    ModelState.AddModelError("Name", "Name can not equal 100");
                    return View(item);
                }
                _context.Items.Update(item);
                _context.SaveChanges();
                TempData["SuccessfullData"] = "Item has been updated succesfully";
                return RedirectToAction("Index");
            }
            return View(item);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var item = _context.Items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            CreateSelectList(item.Id);
            return View(item);
        }
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteItem(Item item)
        {
            try
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
                TempData["SuccessfullData"] = "Item has been removed succesfully";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(item);
            }



        }
        public IActionResult Details(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var item = _context.Items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            CreateSelectList(item.Id);
            return View(item);
        }
        private void CreateSelectList(int? selectId = 0)
        {
            List<Category> categories = _context.Categories.ToList();
            SelectList listItems = new SelectList(categories, "Id", "Name", selectId);
            ViewBag.Categories = listItems;
        }
    }
}
