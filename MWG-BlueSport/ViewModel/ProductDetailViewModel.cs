using System.Collections.Generic;

namespace MWG_BlueSport.Models
{
    public class ProductDetailViewModel : BaseViewModel
    {
        public ProductModel _productModel { get; set; }
        public List<ProductModel> _relatedProducts { get; set; }
    }
}