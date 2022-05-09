using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;
        private readonly IService<Category> _service;
        private readonly IMapper _mapper;

        public CategoriesController(IService<Category> service, IMapper mapper, ICategoryService categoryService = null)
        {
            _service = service;
            _mapper = mapper;
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _service.GetAllAsync();
            var categoryDtos = _mapper.Map<List<CategoryDto>>(categories.ToList());
            return CreateActionResult(CustomResponseDto<List<CategoryDto>>.Success(200, categoryDtos));
        }

        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetCategoryWithProducts(int categoryId)
        {
            var categories = await _categoryService.GetCategoryByIdWithProducts(categoryId);
            return CreateActionResult(categories);
        }

    }
}
