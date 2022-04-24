using LSPOrnek.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPOrnek.Entity
{
    public  class BaseUcak:IKesifYap
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string KesifYap()
        {
            return $"Kesif Yapılıyor";
        }
        //public string HedefVur(); // bu metodu burada tanımladıgımızda alt sınıftaki kesifucagında bu ozellik olmadıgından hata verecek.tanımlanan hersey kullanmalı maddesi geregi bunlar için interface olusturulmalı.
       //baseucak clası bu sayaede kesifucak yerine istenildiginde kullanabilir.
    }
}
