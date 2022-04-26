using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPOrnek
{
    public class Square : IShape
    {
        public Square(double edge)
        {
            Edge = edge;
        }
        public double Edge { get; set; }
        public double AreaCalculation()
        {
            return Edge * Edge;
        }
        //Bu sınıf sekiller interfaceclassından yetenek alarak alan hesaplama metodu buraya tasınır ve bu sınıfa ozgu alan hesabı olusturulur.
    }
}
