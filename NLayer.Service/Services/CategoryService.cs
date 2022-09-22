using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class CategoryService : Service<Category> , ICategoryService

    {

        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<CostumResponseDto<CategoryWithProducts>> GetSingleCategoryWithProductsAsync(int CategoryId)
        {
            var category = await _categoryRepository.GetSingleCategoryWithProductsAsync(CategoryId);
            var categoryDto = _mapper.Map<CategoryWithProducts>(category);

            return CostumResponseDto<CategoryWithProducts>.Success(200, categoryDto);
        }
    }
}
