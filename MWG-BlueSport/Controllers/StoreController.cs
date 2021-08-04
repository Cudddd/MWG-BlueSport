using System.Threading.Tasks;
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
        
        public StoreController(IStoreService storeService, ICategoryService categoryService)
        {
            _storeService = storeService;
        }
        // GET
        [Route("cua-hang/{slug}")]
        public async Task<IActionResult> Detail(string slug)
        {
            var viewModel = new StoreDetailViewModel();

            viewModel._store = await _storeService.GetBySlug(slug);

            viewModel._grandOpeningStore = await _storeService.GetAll();
            
            return View(viewModel);
        }
    }
}