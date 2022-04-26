using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPOrnek
{
    public class MalzemeIslemleri
    {
        public void MalzemeEkle(string malzeme)
        {
            Pizza.MalzemeListesi.Add(malzeme);
            Console.WriteLine(malzeme + " eklendi");
        }

        public void MalzemeCıkar(string malzeme)
        {
            Pizza.MalzemeListesi.Remove(malzeme);
            Console.WriteLine(malzeme + " çıkarıldı");
        }

        public List<string> MalzemeleriGoster()
        {
            return Pizza.MalzemeListesi.ToList();
        }

        //Malzemeler ile ilgili işlemler yapıyor.Bu classta sadece malzeme ekleme, cıkarma ve listeleme islemleri burada yapılacak.
        //Her class tek bir görev yapmalıdır.
    }
}
