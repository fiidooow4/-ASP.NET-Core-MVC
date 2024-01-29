using Microsoft.AspNetCore.Mvc;
using MVC_EX.Models;

namespace MVC_EX.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductRepo _repo;

        public ProductController(IProductRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index()

        {
            var products = _repo.GetAllProducts();
          

            return View(products);
        }

        public IActionResult ViewProduct(int id)
        {
            var product = _repo.GetProduct(id);
            return View(product);
        }

        

        public IActionResult UpdateProductToDatabase(Product product)
        {
            _repo.UpdateProduct(product);

            return RedirectToAction("ViewProduct", new { id = product.ProductID });
        }

        public IActionResult DeleteProduct(Product product)
        {
            _repo.DeleteProduct(product);
            return RedirectToAction("Index");
        }
    }


}
