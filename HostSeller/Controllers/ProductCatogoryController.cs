using EngineSeller.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ModelSeller;

namespace HostSeller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCatogoryController : ControllerBase
    {
        #region Dependencies
        private readonly IProductCategoryEngine _productCategoryEngine;
        #endregion
        public ProductCatogoryController(IProductCategoryEngine productCategoryEngine)
        {
                this._productCategoryEngine = productCategoryEngine;
        }

        /// <summary>
        /// Use this endpoint to add single product category.
        /// </summary>
        /// <param name="productCategory"></param>
        /// <returns>Returns created product category if successfully created</returns>
        [HttpPost("CreateProductCategory")]
        public async Task<IActionResult> CreateProductCategory(ProductCategory productCategory)
        {
            await _productCategoryEngine.CreateProductCategoryEngineAsync(productCategory);
            return CreatedAtAction(nameof(GetProductCategory), new { id = productCategory.Id }, productCategory);
        }


        /// <summary>
        /// Use this endpoint to get specific product category
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return product category if id matched return product category</returns>
        [HttpGet("GetProductCategory")]
        public async Task<ProductCategory> GetProductCategory(string id)
        {
            return await _productCategoryEngine.GetProductCategoryEngineAsync(id);
        }
    }
}
