using System.Collections.Generic;
using RestSharp;

namespace MWG_BlueSport.Service.Client
{
    public interface IClientService
    {
        public IRestResponse Get(string path);
    }
}