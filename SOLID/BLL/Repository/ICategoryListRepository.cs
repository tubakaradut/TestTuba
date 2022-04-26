using DataAcces.Entity;
using System.Collections.Generic;

namespace BLL.Repository
{
    public interface ICategoryListRepository
    {
        List<Category> GetCategoryList();
    }
}
