using System.Collections.Generic;
using MWG_BlueSport.Models;

namespace MWG_BlueSport.Service.Product
{
    public interface IProductService
    {
        public List<ProductModel> GetAll();
        public ProductModel Get(string id);
        public ProductModel GetBySlug(string slug);
    }
}