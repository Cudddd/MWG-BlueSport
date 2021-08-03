using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using MWG_BlueSport.Models;
using MWG_BlueSport.Service.Category;
using MWG_BlueSport.Service.Store;

namespace MWG_BlueSport.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreService _storeService;

        private readonly ICategoryService _categoryService;

        public StoreController(IStoreService storeService, ICategoryService categoryService)
        {
            _storeService = storeService;
            _categoryService = categoryService;
        }
        // GET
        [Route("cua-hang/{slug}")]
        public IActionResult Detail(string slug)
        {
            var viewModel = new StoreDetailViewModel();
            
            viewModel._categories = _categoryService.GetAll();
            
            viewModel._store = _storeService.GetBySlug(slug);

            viewModel._grandOpeningStore = _storeService.GetAll();
            
            return View(viewModel);
        }
    }
}