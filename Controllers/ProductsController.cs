using Microsoft.AspNetCore.Mvc;
using Task_1_mvc.Data;
using Task_1_mvc.Models;

namespace Task_1_mvc.Controllers
{
    public class ProductsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ViewResult Index()
        {
            var products = context.products.ToList();
            return View(products);
        }
        public ViewResult Details(int id)
        {
            var product = context.products.Find(id);
            return View(product);
        }
        public ViewResult Create()
        {
            return View(new Product());
        }
        public IActionResult Add(Product request)
        {
            if (ModelState.IsValid)
            {
                context.products.Add(request);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create",request);
            }
        }
        public IActionResult Delete(int id)
        {
            var product = context.products.Find(id);
            if (product is null)
            {
                return View("NotFound");
            }
            context.products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
