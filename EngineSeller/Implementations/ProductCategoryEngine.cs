using DataSeller.Interfaces;
using EngineSeller.Interfaces;
using ModelSeller;

namespace EngineSeller.Implementations
{
    public class ProductCategoryEngine : IProductCategoryEngine
    {
        #region Dependencies
        private readonly IProductCategoryData _productCategoryData;
        #endregion

        public ProductCategoryEngine(IProductCategoryData productCategoryData)
        {
           this._productCategoryData = productCategoryData;
        }

        public async Task CreateProductCategoryEngineAsync(ProductCategory productCategory)
        {
           await _productCategoryData.CreateProductCategoryDataAsync(productCategory);
        }

        public async Task<ProductCategory> GetProductCategoryEngineAsync(string id)
        {
           return await _productCategoryData.GetProductCategoryDataAsync(id);
        }
    }
}
