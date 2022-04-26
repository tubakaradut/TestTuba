using BLL.Interfaces;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public interface IProductRepository:ICrud<Product>
    {
        string DeleteProduct(int id);
        List<Product> GetProductList();

    }
}
