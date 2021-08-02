using MWG_BlueSport.Models;

namespace MWG_BlueSport.ModelDTO
{
    public class StoreDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string webAddress { get; set; }
    }

    public static class StoreDTOExt
    {
        public static StoreModel ToStoreModel(this StoreDTO storeDto)
        {
            return new StoreModel()
            {
                name = storeDto.name,
                address = storeDto.GetAddress(),
            };
        }

        public static string GetAddress(this StoreDTO storeDto)
        {
            return string.IsNullOrEmpty(storeDto.webAddress) ? storeDto.address : storeDto.webAddress;
        }
    }
}