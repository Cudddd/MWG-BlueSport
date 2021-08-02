using Microsoft.AspNetCore.Mvc;
using MWG_BlueSport.Models;
using MWG_BlueSport.Service.Product;

namespace MWG_BlueSport.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET
        [Route("san-pham/{slug}")]
        public IActionResult Detail(string slug)
        {
            ProductDetailViewModel viewModel = new ProductDetailViewModel();
            viewModel._productModel = _productService.GetBySlug(slug);
            viewModel._relatedProducts = _productService.GetAll();
            
            return View(viewModel);
        }
    }
}