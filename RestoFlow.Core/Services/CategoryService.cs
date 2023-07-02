using AutoMapper;

using RestoFlow.Core.Common;
using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Category;
using RestoFlow.Core.Models.Product;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public CategoryService(IRepository _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
        }

        public async Task<List<CategoryDTO>> GetAllCategories()
        {
            var categories = repository.All<Category>().Where(c => !c.IsDeleted);
            return categories.Select(category => mapper.Map<CategoryDTO>(category)).ToList();
        }
    }
}
