using System.Collections.Generic;

namespace MWG_BlueSport.Models
{
    public class CategoryModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public List<CategoryModel> subCate { get; set; }
    }
}