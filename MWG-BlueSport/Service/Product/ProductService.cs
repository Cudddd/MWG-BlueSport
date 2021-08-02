using System.Collections.Generic;
using System.Linq;
using MWG_BlueSport.ModelDTO;
using MWG_BlueSport.Models;
using MWG_BlueSport.Service.Client;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace MWG_BlueSport.Service.Product
{
    public class ProductService : IProductService
    {
        private string _apiName;
        private readonly IClientService _clientService;

        public ProductService(IClientService clientService)
        {
            _clientService = clientService;

            _apiName = "product";
        }
        public List<ProductModel> GetAll()
        {
            #region Get Data DTO => API

            var response = _clientService.Get(_apiName);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProductDTO>>(response.Content);
            #endregion

            List<ProductModel> productModels = new List<ProductModel>();
            
            foreach (var item in dataDto)
            {
                productModels.Add(item.ToProductModel());
            }

            return productModels;
        }

        public ProductModel Get(string id)
        {
            var response = _clientService.Get(_apiName + "/" + id);

            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductDTO>(response.Content);

  
            return dataDto.ToProductModel();
        }

        public ProductModel GetBySlug(string slug)
        {
            var response = _clientService.Get(_apiName + "/" + slug);

            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductDTO>(response.Content);

  
            return dataDto.ToProductModel();
        }
    }
}