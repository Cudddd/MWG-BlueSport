using System.Collections.Generic;
using MWG_BlueSport.ModelDTO;
using MWG_BlueSport.Models;
using RestSharp;

namespace MWG_BlueSport.Service.Product
{
    public class ProductService : IProductService
    {
        public List<ProductModel> GetAll()
        {
            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/thamminhduc/Bluesport/1.0.0/product");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProductModel>>(response.Content);
            #endregion

            List<ProductModel> productModels = new List<ProductModel>();
            
            foreach (var item in dataDto)
            {
                productModels.Add(new ProductModel()
                {
                    name = item.name,
                    image = item.image,
                    priceCurrent = item.priceCurrent,
                    priceOld = item.priceOld,
                    saleOff = item.saleOff,
                    brandName = item.brandName,
                    imageBrand = item.imageBrand
                });
            }

            return productModels;
        }
    }
}