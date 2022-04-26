using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPOrnek
{
  public  class Yonetici
    {
        private IMevzuat _mevzuat;

        public Yonetici(IMevzuat mevzuat)
        {
            _mevzuat = mevzuat;
        }

        public void Ekle()
        {
            _mevzuat.Islem();
        }
    }
}
