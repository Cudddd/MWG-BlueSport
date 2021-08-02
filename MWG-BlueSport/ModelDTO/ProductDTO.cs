using MWG_BlueSport.Models;

namespace MWG_BlueSport.ModelDTO
{
    public class ProductDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string priceCurrent { get; set; }
        public string priceOld { get; set; }
        public string saleOff { get; set; }
        public string brandName { get; set; }
        public string imageBrand { get; set; }
    }

    public static class ProductDTOExt
    {
        public static ProductModel ToProductModel(this ProductDTO productDto)
        {
            return new ProductModel()
            {
                name = productDto.name,
                image = productDto.image,
                priceCurrent = productDto.priceCurrent,
                priceOld = productDto.priceOld,
                saleOff = productDto.saleOff,
                brandName = productDto.brandName,
                imageBrand = productDto.imageBrand
            };
        }
    }
}