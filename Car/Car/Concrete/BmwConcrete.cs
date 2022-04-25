using Car.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Entity;

namespace Car.Concrete
{
    public class BmwConcrete : CarOlustur
    {
        public BmwConcrete()
        {
            araba = new Araba();
        }


        public override void CreateBrandName()
        {
            araba.BrandName = "BMV";
        }

        public override void CreateColor()
        {
            araba.Color = "Beyaz";
        }

        public override void CreateModelName()
        {
            araba.ModelName = "1.16";
        }
    }
}
