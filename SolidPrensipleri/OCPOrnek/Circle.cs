using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPOrnek
{
    public class Circle :IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }

        public double AreaCalculation()
        {
            return Radius * Radius * Math.PI;
        }
         //Bu sınıf sekiller interfaceclassından yetenek alarak alan hesaplama metodu buraya tasınır ve bu sınıfa ozgu alan hesabı olusturulur.
    }
}