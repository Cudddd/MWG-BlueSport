using System.Collections.Generic;
using MWG_BlueSport.ModelDTO;
using MWG_BlueSport.Models;

namespace MWG_BlueSport.Service.Banner
{
    public interface IBannerService
    {
        public List<BannerModel> GetAll();
    }
}