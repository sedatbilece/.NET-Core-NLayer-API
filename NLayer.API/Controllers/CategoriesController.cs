using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    
    public class CategoriesController : CostumBaseController
    {
        private readonly ICategoryService _categoryService;


        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        //api/categories/GetSingleCategoryWithProducts/1
        [HttpGet("[action]/{CategoryId}")]
        public async Task<IActionResult> GetSingleCategoryWithProducts(int CategoryId)
        {
            return CreateActionResult(await _categoryService.GetSingleCategoryWithProductsAsync(CategoryId));
        }
    }
}
