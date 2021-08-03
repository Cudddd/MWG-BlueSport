using MWG_BlueSport.Models;

namespace MWG_BlueSport.ModelDTO
{
    public class CategoryDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public string parentId { get; set; }
    }

    public static class CategoryDTOExt
    {
        public static CategoryModel ToCategoryModel(this CategoryDTO cate)
        {
            return new CategoryModel()
            {
                id = cate.id,
                name = cate.name,
                level = cate.level,
            };
        }
    }
    
}