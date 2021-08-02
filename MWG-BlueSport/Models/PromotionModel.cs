using System.Collections.Generic;
using MWG_BlueSport.ModelDTO;

namespace MWG_BlueSport.Models
{
    public class PromotionModel
    {
        public string promotionName { get; set; }
        public List<PromotionDetailModel> promotionList { get; set; }
    }
}