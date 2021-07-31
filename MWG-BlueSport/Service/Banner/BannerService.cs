using System;
using System.Collections.Generic;
using MWG_BlueSport.ModelDTO;
using MWG_BlueSport.Models;
using RestSharp;

namespace MWG_BlueSport.Service.Banner
{
    public class BannerService : IBannerService
    {
        public List<BannerModel> GetAll()
        {
            #region Get Data DTO => API
            var client = new RestClient("https://virtserver.swaggerhub.com/thamminhduc/Bluesport/1.0.0/banner");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BannerDTO>>(response.Content);
            #endregion

            List<BannerModel> bannerModels = new List<BannerModel>();
            
            //mapping
            foreach (var item in dataDto)
            {
                bannerModels.Add(new BannerModel()
                {
                    pathImg = item.pathImg,
                    altImg = item.altImg,
                    description = item.description
                });
            }

            return bannerModels;
        }
    }
}