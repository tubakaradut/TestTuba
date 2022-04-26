using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(15, 12);

            Console.WriteLine("Dikdötgenin Alanı: " + rectangle.AreaCalculation());
            Console.ReadLine();


            Console.WriteLine("Karenin kenar uzunlugunu giriniz");
            string x = Console.ReadLine();
            Square square = new Square(Convert.ToDouble(x));
            Console.WriteLine("karenin alanı hesaplanıyor");
            Console.WriteLine(square.AreaCalculation());
            Console.ReadLine();

            Console.WriteLine("Dairenin yarıcapını giriniz.. ");
            string y = Console.ReadLine();
            Circle circle = new Circle(Convert.ToDouble(y));
            Console.WriteLine("dairenin alanı hesaplanıyor");
            Console.WriteLine(circle.AreaCalculation());
            Console.ReadLine();
        }
    }
}
