using ApiJwt.Models;

namespace ApiJwt.Constans
{
    public class ProductConstants
    {
        public static List<ProductModel> products = new List<ProductModel>()
        {
            new ProductModel(){Name = "Coca Cola", Description = "Gaseosa con gas"},
            new ProductModel(){Name = "Agua Manantial", Description = "Agua mineral"}
        };
    }
}
