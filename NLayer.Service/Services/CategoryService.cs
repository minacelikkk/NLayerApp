using AutoMapper;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
namespace NLayer.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IGenericRepository<Category> genericRepository, IUnitOfWork unitOfWork, ICategoryRepository categoryRepository, IMapper mapper) : base(genericRepository, unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<CategoryWithProductsDto>> GetCategoryByIdWithProducts(int categoryId)
        {
            var categories=await _categoryRepository.GetCategoryWithProductsAsync(categoryId);
            var categoryDtos = _mapper.Map<CategoryWithProductsDto>(categories);
            return CustomResponseDto<CategoryWithProductsDto>.Success(200, categoryDtos);
        }
    }
}
