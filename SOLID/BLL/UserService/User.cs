using BLL.Repository;
using DataAcces.Context;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UserService
{
    public class User : AppUser, IProductListRepository, ICategoryListRepository
    {
        ProjeContext db = new ProjeContext();
        public List<Category> GetCategoryList()
        {
            return db.categories.ToList();
        }

        public List<Product> GetProductList()
        {
            return db.products.ToList();
        }
    }
}
