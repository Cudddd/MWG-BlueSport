using System.Collections.Generic;

namespace MWG_BlueSport.Models
{
    public class HomeViewModel
    {
        public List<BannerModel> bannerModels { get; set; }
        public List<StoreModel> storeModels { get; set; }
        public  List<ProductModel> productModels { get; set; }
    }
}