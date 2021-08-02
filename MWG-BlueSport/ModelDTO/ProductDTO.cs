using System.Collections.Generic;
using System.Drawing;
using MWG_BlueSport.Models;

namespace MWG_BlueSport.ModelDTO
{
    public class ProductDTO
    {
        public string id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string priceCurrent { get; set; }
        public string priceOld { get; set; }
        public string saleOff { get; set; }
        public string brandName { get; set; }
        public string brandInfo { get; set; }
        public string description { get; set; }
        public string imageBrand { get; set; }
        public Dictionary<string,string>[] productDetail { get; set; }
        public List<SizeDTO> sizes { get; set; }
        public PromotionDTO promotion { get; set; }
    }

    public static class ProductDTOExt
    {
        public static ProductModel ToProductModel(this ProductDTO productDto)
        {
            var result = new ProductModel()
            {
                id = productDto.id,
                name = productDto.name,
                image = productDto.image,
                priceCurrent = productDto.priceCurrent,
                priceOld = productDto.priceOld,
                saleOff = productDto.saleOff,
                brandName = productDto.brandName,
                brandInfo = productDto.brandInfo,
                description = productDto.description,
                imageBrand = productDto.imageBrand,
                productDetail = productDto.productDetail,
                
                slug = productDto.slug,
                promotion = productDto.promotion.ToPromotionModel()
            };
            
            result.sizes = new List<SizeModel>();
            if (productDto.sizes != null)
            {
                foreach (var item in productDto.sizes)
                {
                    result.sizes.Add(item.ToSizeModel());
                }
            }
            
            return result;
        }
    }
}