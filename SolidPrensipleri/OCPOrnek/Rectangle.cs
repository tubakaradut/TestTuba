using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPOrnek
{
    public class Rectangle:IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public double AreaCalculation()
        {
            return Width * Height;
        }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        //Bu sınıf ssekiller interfaceclassından yetenek alarak alan hesaplama metodu buraya tasınır ve bu sınıfa ozgu alan hesabı olusturulur.
    }
}
