using System.Collections.Generic;
using System.Threading.Tasks;
using MWG_BlueSport.ModelDTO;
using MWG_BlueSport.Models;
using MWG_BlueSport.Service.Client;
using RestSharp;

namespace MWG_BlueSport.Service.Store
{
    public class StoreService : IStoreService
    {
        private string _apiName;
        private readonly IClientService _clientService;

        public StoreService(IClientService clientService)
        {
            _clientService = clientService;

            _apiName = "store";
        }
        public async Task<List<StoreModel>> GetAll()
        {
            #region Get Data DTO => API
            var response = await _clientService.Get(_apiName);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<StoreDTO>>(response.Content);
            #endregion

            List<StoreModel> storeModels = new List<StoreModel>();
            foreach (var item in dataDto)
            {
                storeModels.Add(item.ToStoreModel());
            }

            return storeModels;
        }

        public async Task<StoreModel> GetBySlug(string slug)
        {
            var response = await _clientService.Get(_apiName + "/" + slug);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<StoreDTO>(response.Content);

            return dataDto.ToStoreModel();
        }
    }
}