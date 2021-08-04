using System.Collections.Generic;
using System.Threading.Tasks;
using MWG_BlueSport.Models;

namespace MWG_BlueSport.Service.Store
{
    public interface IStoreService
    {
        public Task<List<StoreModel>> GetAll();
        public Task<StoreModel> GetBySlug(string slug);
    }
}