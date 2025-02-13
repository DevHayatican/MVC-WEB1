using Web1.context;
using Web1.entity;
using Web1.Models;

namespace Web1.service.concrete
{
    public class CategoryService : ICategoryService
    {
        private NorthwindDB _db;

        public CategoryService(NorthwindDB db)
        {
            _db = db;
        }

        public List<CategoryModel> GetAll()
        {
            List<CategoryModel> categoryModels = new List<CategoryModel>();

            foreach (Category item in _db.Categories.ToList())  
            {
                CategoryModel categoryModel = new CategoryModel();
                categoryModel.id = item.CategoryID;
                categoryModel.CategoryName = item.CategoryName;
                categoryModels.Add(categoryModel);

            }

            return categoryModels;
        }
    }
}
