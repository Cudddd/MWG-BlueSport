using MWG_BlueSport.Models;

namespace MWG_BlueSport.ModelDTO
{
    public class PromotionDetailDTO
    {
        public string promotionInfo { get; set; }
        public bool isOnlinePromotion { get; set; }
        public bool isMore { get; set; }
    }
    
    public static class PromotionDetailDTOExt
    {
        public static PromotionDetailModel ToPromotionDetailModel(this PromotionDetailDTO promotionDetail)
        {
            return new PromotionDetailModel()
            {
               promotionInfo = promotionDetail.promotionInfo,
               isOnlinePromotion = promotionDetail.isOnlinePromotion,
               isMore = promotionDetail.isMore,
            };
        }
    }
}