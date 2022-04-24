namespace KarakterOlustur
{
    public class Factory
    {
        public HareketTurleri FactoryMethod(Sinif sinif,Karakter karakter)
        {
            HareketTurleri ht = null;
            Warrior warrior=null;
            Hunter hunter=null;

            switch (karakter)
            {
                case Karakter.Warrior:
                    warrior = new Warrior();
                    ht = warrior;
                    break;
                case Karakter.Hunter:
                    hunter = new Hunter();
                    ht = hunter;
                    break;
                case Karakter.Priest:
                    break;
            }

            switch (sinif)
            {
                case Sinif.Insan:
                    warrior.Name = "Insan";
                    break;
                case Sinif.Dwart:
                    ht = new Warrior();
                    break;
                case Sinif.NightElf:
                    ht = new Warrior();
                    break;
                case Sinif.Org:
                    hunter.Name = "Org";
                    break;
            }
            return ht;
        }
    }
}
