using Car.Abstract;
using Car.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
public    class CarKullan
    {
        public void ArabaKullan(CarOlustur Araba)
        {
            Araba.CreateBrandName();
            Araba.CreateColor();
            Araba.CreateModelName();

        }
    }
}
