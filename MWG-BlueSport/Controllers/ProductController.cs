using Microsoft.AspNetCore.Mvc;
using MWG_BlueSport.Models;
using MWG_BlueSport.Service.Category;
using MWG_BlueSport.Service.Product;

namespace MWG_BlueSport.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        // GET
        [Route("san-pham/{slug}")]
        public IActionResult Detail(string slug)
        {
            ProductDetailViewModel viewModel = new ProductDetailViewModel();
            
            viewModel._productModel = _productService.GetBySlug(slug);
            
            viewModel._relatedProducts = _productService.GetAll();

            viewModel._categories = _categoryService.GetAll();
            
            return View(viewModel);
        }
    }
}