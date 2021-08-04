using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;

namespace MWG_BlueSport.Service.Client
{
    public interface IClientService
    {
        public Task<IRestResponse> Get(string path);
    }
}