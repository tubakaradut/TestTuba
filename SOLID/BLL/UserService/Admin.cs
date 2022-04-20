using BLL.Interfaces;
using BLL.Repository;
using DataAcces.Context;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.UserService
{
    public class Admin : AppUser, IProductRepository, ICategoryRepository
    {
        ProjeContext db = new ProjeContext();
        public string Create(Product model)
        {
            db.products.Add(model);
            db.SaveChanges();

            return "eklendi";
        }

        public string Create(Category model)
        {
            db.categories.Add(model);
            db.SaveChanges();

            return "eklendi";
        }

        public string DeleteCategory(int id)
        {
            Category delete = db.categories.Find(Id);
            db.categories.Remove(delete);
            db.SaveChanges();
            return $"silindi";
        }

        public string DeleteProduct(int id)
        {
            Product delete = db.products.Find(Id);
            db.products.Remove(delete);
            db.SaveChanges();
            return $"silindi";
        }

        public List<Category> GetCategoryList()
        {
            return db.categories.ToList();
        }

        public List<Product> GetProductList()
        {
            return db.products.ToList();
        }

        public string Update(Product model)
        {
            db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return $"güncellendi";
        }

        public string Update(Category model)
        {
            db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return $"güncellendi";
        }

    }
}
