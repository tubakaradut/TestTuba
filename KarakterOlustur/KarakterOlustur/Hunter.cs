using System;

namespace KarakterOlustur
{
    public class Hunter: IKarakter
    {
        public int _id = 2;
        public string _name = "Hunter";
        public int _level = 2;
        public int _damage = 4;


        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Level { get => _level; set => _level = value; }
        public int Damage { get => _damage; set => _damage = value; }

        public override void Attack()
        {
            Console.WriteLine($"{Name} ok ile {Damage} şiddetinde atak yaptı.");
        }

        public override void Defense()
        {
            Console.WriteLine($"{Name} ok ile savunma yaptı.");
        }
    }
}
