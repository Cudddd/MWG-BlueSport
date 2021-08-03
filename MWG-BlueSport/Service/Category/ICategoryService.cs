using System.Collections.Generic;
using MWG_BlueSport.ModelDTO;
using MWG_BlueSport.Models;

namespace MWG_BlueSport.Service.Category
{
    public interface ICategoryService
    {
        public List<CategoryModel> GetAll();
    }
}