using DataSeller.Interfaces;
using Microsoft.Extensions.Options;
using ModelSeller;
using ModelSeller.Utility;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataSeller.Implementations
{
    public class ProductCategoryData : IProductCategoryData
    {

        private readonly IMongoCollection<ProductCategory> _productCategoryCollection;
        public ProductCategoryData(IOptions<MDSettings> mongoDBSettings, IOptions<MDCollections> mongoDBCollection)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURL);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.Database);
            _productCategoryCollection = database.GetCollection<ProductCategory>(mongoDBCollection.Value.ProductCategory);
        }

        public async Task CreateProductCategoryDataAsync(ProductCategory productCategory)
        {
           await _productCategoryCollection.InsertOneAsync(productCategory);
        }

        public async Task<ProductCategory> GetProductCategoryDataAsync(string id)
        {
            FilterDefinition<ProductCategory> filterDefination = Builders<ProductCategory>.Filter.Eq("status", "D");
            ProductCategory productCategory = await _productCategoryCollection.Find(filterDefination).FirstOrDefaultAsync();
            return productCategory;
        }
    }
}
