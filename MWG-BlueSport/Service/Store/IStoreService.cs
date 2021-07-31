using System.Collections.Generic;
using MWG_BlueSport.Models;

namespace MWG_BlueSport.Service.Store
{
    public interface IStoreService
    {
        public List<StoreModel> GetAll();
    }
}