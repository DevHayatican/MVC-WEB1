using Web1.context;
using Web1.entity;
using Web1.Models;

namespace Web1.service.concrete
{
    public class ProductService : IProductService
    {
        private NorthwindDB _northwindDB;

        public ProductService(NorthwindDB northwindDB)
        {
            _northwindDB = northwindDB;
        }


        public List<ProductModel> getAllProducts(int? id)
        {
            List<Product> products = new List<Product>();

            if (id == null)
            {
                products = _northwindDB.Products.ToList();
            }
            else
            {
                products = _northwindDB.Products
                    .Where(x => x.Category.CategoryID == id).ToList();
            }



            List<ProductModel> productModels = new List<ProductModel>();

            foreach (Product item in products)
            {
                ProductModel productModel = new ProductModel();

                productModel.Name = item.ProductName;
                productModel.Stock = item.UnitsInStock;
                productModel.Price = item.UnitPrice;
                productModels.Add(productModel);

            }

            productModels = productModels.Take(15)
              .OrderByDescending(x => x.Name)
            .ToList();



            return productModels;

        }
    }
}
