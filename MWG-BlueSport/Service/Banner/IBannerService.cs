using System.Collections.Generic;
using System.Threading.Tasks;
using MWG_BlueSport.ModelDTO;
using MWG_BlueSport.Models;

namespace MWG_BlueSport.Service.Banner
{
    public interface IBannerService
    {
        public Task<List<BannerModel>> GetAll();
    }
}