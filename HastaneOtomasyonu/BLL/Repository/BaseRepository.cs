using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        readonly HastaneOtomasyonuEntities db = new HastaneOtomasyonuEntities();
        public T Create(T model)
        {
            try
            {
                var result = db.Set(typeof(T)).Add(model);
                db.SaveChanges();
                return (T)result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Delete(int id)
        {
            try
            {
                var deleted = db.Set(typeof(T)).Find(id);
                db.Set(typeof(T)).Remove(deleted);
                db.SaveChanges();
                return "veri silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public T FindById(int id)
        {
            return db.Set(typeof(T)).Cast<T>().Find(id);
        }

        public List<T> GetList()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }

        public List<T> GetList(Func<T, bool> where)
        {
            return db.Set(typeof(T)).Cast<T>().AsNoTracking().Where(where).ToList();
        }

        public string Update(T model)
        {
            try
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "veri güncellendi!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
