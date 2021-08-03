using System.Collections.Generic;

namespace MWG_BlueSport.Models
{
    public class StoreDetailViewModel : BaseViewModel
    {
        public StoreModel _store { get; set; }
        public List<StoreModel> _grandOpeningStore { get; set; }
    }
}