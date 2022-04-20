using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entity
{
    public class Category:BaseClass
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public int ProductId { get; set; }
       
        public List<Product> Products { get; set; }
    }
}
