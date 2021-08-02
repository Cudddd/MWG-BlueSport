using MWG_BlueSport.Models;

namespace MWG_BlueSport.ModelDTO
{
    public class BannerDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string pathImg { get; set; }
        public string altImg { get; set; }
        public string description { get; set; }
    }

    public static class BannerDTOExt
    {
        public static BannerModel ToBannerModel(this BannerDTO bannerDto)
        {
            return new BannerModel()
            {
                pathImg = bannerDto.pathImg,
                altImg = bannerDto.altImg,
                description = bannerDto.description
            };
        }
    }
    
}