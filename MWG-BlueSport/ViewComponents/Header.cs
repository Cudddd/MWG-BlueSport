using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MWG_BlueSport.Models;
using MWG_BlueSport.Service.Category;

namespace MWG_BlueSport.ViewComponents
{
    public class Header : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public Header(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            List<CategoryModel> models = await _categoryService.GetAll();
            
            return View(models);
        }
    }
}