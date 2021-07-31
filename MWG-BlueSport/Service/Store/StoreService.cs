using System.Collections.Generic;
using MWG_BlueSport.ModelDTO;
using MWG_BlueSport.Models;
using RestSharp;

namespace MWG_BlueSport.Service.Store
{
    public class StoreService : IStoreService
    {
        public List<StoreModel> GetAll()
        {
            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/thamminhduc/Bluesport/1.0.0/store");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<StoreDTO>>(response.Content);
            #endregion

            List<StoreModel> storeModels = new List<StoreModel>();
            foreach (var item in dataDto)
            {
                storeModels.Add(new StoreModel()
                {
                    name = item.name,
                    address = item.address
                });
            }

            return storeModels;
        }
    }
}