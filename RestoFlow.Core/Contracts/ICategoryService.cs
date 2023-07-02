using RestoFlow.Core.Models.Category;

namespace RestoFlow.Core.Contracts
{
    public interface ICategoryService
    {
        Task<List<CategoryDTO>> GetAllCategories();
    }
}
