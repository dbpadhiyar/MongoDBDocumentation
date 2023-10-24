using ModelSeller;

namespace DataSeller.Interfaces
{
    public interface IProductCategoryData
    {
        Task CreateProductCategoryDataAsync(ProductCategory productCategory);

        Task<ProductCategory> GetProductCategoryDataAsync(string id);
    }
}
