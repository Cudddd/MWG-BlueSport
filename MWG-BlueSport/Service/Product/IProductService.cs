using System.Collections.Generic;
using System.Threading.Tasks;
using MWG_BlueSport.Models;

namespace MWG_BlueSport.Service.Product
{
    public interface IProductService
    {
        public Task<List<ProductModel>> GetAll();
        public Task<ProductModel> Get(string id);
        public Task<ProductModel> GetBySlug(string slug);
    }
}