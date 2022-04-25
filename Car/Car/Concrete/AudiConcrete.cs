using Car.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Entity;

namespace Car.Concrete
{
    public class AudiConcrete : CarOlustur
    {
        public AudiConcrete()
        {
            araba = new Araba();
        }

        public override void CreateBrandName()
        {
            araba.BrandName = "Audi";
        }

        public override void CreateColor()
        {
            araba.Color = "Siyah";
        }

        public override void CreateModelName()
        {
            araba.ModelName = "A3";
        }
    }
}
