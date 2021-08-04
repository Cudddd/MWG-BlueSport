using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MWG_BlueSport.ModelDTO;
using MWG_BlueSport.Models;
using MWG_BlueSport.Service.Client;
using RestSharp;

namespace MWG_BlueSport.Service.Banner
{
    public class BannerService : IBannerService
    {
        private string _apiName;
        private readonly IClientService _clientService;

        public BannerService(IClientService clientService)
        {
            _clientService = clientService;

            _apiName = "banner";
        }
        public async Task<List<BannerModel>> GetAll()
        {
            #region Get Data DTO => API

            var response = await _clientService.Get(_apiName);

            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BannerDTO>>(response.Content);
            #endregion

            List<BannerModel> bannerModels = new List<BannerModel>();
            
            //mapping
            foreach (var item in dataDto)
            {
                bannerModels.Add(item.ToBannerModel());
            }

            return bannerModels;
        }
    }
}