using Car.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Entity;


namespace Car.Concrete
{
    public class MercedesConcrete : CarOlustur
    {
        public MercedesConcrete()
        {
            araba = new Araba();
        }


        public override void CreateBrandName()
        {
            araba.BrandName = "Mercedes";
        }

        public override void CreateColor()
        {
            araba.Color = "Kırmızı";
        }

        public override void CreateModelName()
        {
            araba.ModelName = "A 108";
        }
    }
}
