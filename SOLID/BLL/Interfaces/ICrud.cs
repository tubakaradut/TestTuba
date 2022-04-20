using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICrud<T> where T : BaseClass
    {
        //Create
        string Create(T model);
        //List
        //List<T> GetList();

        //Update
        string Update(T model);

        //Delete
        //string Delete(int id);
    }
}
