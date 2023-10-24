using ModelSeller;

namespace EngineSeller.Interfaces
{
    public interface IProductCategoryEngine
    {
        Task CreateProductCategoryEngineAsync(ProductCategory productCategory);

        Task<ProductCategory> GetProductCategoryEngineAsync(string id);
        
    }
}
