using BLL.Interfaces;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public interface ICategoryRepository:ICrud<Category>
    {
        string DeleteCategory(int id);

        List<Category> GetCategoryList();
    }
}
