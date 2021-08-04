using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MWG_BlueSport.Models;
using MWG_BlueSport.Service.Category;
using MWG_BlueSport.Service.Product;

namespace MWG_BlueSport.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
        }
        // GET
        [Route("san-pham/{slug}")]
        public async Task<IActionResult> Detail(string slug)
        {
            ProductDetailViewModel viewModel = new ProductDetailViewModel();
            
            viewModel._productModel = await _productService.GetBySlug(slug);
            
            viewModel._relatedProducts = await _productService.GetAll();

            return View(viewModel);
        }
    }
}