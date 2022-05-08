using System.ComponentModel.DataAnnotations;

namespace DataAcces.Entity
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public bool IsActive => true;
    }
}
