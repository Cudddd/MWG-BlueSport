using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MWG_BlueSport.Models;

namespace MWG_BlueSport.ModelDTO
{
    public class StoreDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string address { get; set; }
        public string webAddress { get; set; }
        public string operatingTime { get; set; }
        public long phoneNumber { get; set; }
        public List<string> promotion { get; set; }
        public List<string> images { get; set; }
    }

    public static class StoreDTOExt
    {
        public static StoreModel ToStoreModel(this StoreDTO storeDto)
        {
            return new StoreModel()
            {
                name = storeDto.name,
                slug = storeDto.slug,
                address = storeDto.GetAddress(),
                operatingTime = storeDto.operatingTime,
                phoneNumber = storeDto.phoneNumber,
                promotion = storeDto.promotion,
                images = storeDto.images
            };
        }

        public static string GetAddress(this StoreDTO storeDto)
        {
            return string.IsNullOrEmpty(storeDto.webAddress) ? storeDto.address : storeDto.webAddress;
        }

    }
}