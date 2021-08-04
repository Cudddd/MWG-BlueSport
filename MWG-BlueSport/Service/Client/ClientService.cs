using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace MWG_BlueSport.Service.Client
{
    public class ClientService : IClientService
    {
        private string _url;
        private string _basePath;

        public ClientService()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            
            var url = configuration.GetSection("BaseUrl").Value;
            var basePath = configuration.GetSection("BasePath").Value;

            _url = url;
            _basePath = basePath;
        }
        public async Task<IRestResponse> Get(string path)
        {
            var client = new RestClient(_url + _basePath + path);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            var response = await client.ExecuteAsync(request);

            return response;
        }
    }
}