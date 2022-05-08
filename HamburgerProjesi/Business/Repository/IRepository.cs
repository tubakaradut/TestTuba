using DataAcces.Enums;
using System;
using System.Collections.Generic;

namespace Business.Repository
{
    public interface IRepository<T> where T : class
    {
        T Create(T model);
        //List
        List<T> GetList();

        //List Where SiparisStatus
        List<T> GetList(Func<T, Boolean> where);

        //Update
        string Update(T model);

        //Delete
        string Delete(int id);

        T FindById(int id);
    }
}
