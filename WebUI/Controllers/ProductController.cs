using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var result = _productService.GetAll();  
            return View(result);
        }

        public IActionResult GetCategory(int id)
        {
            var result = _productService.GetByCategory(id);
            return View(result);
        }
        public IActionResult GetDetail(int id)
        {
            var result = _productService.GetByDetail(id);
            return View(result);
        }
    }
}
