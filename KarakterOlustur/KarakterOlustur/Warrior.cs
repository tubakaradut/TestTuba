using System;

namespace KarakterOlustur
{
    public class Warrior : IKarakter
    {
        public int _id = 1;
        public string _name = "Warrior";
        public int _level = 5;
        public int _damage = 5;


        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Level { get => _level; set => _level = value; }
        public int Damage { get => _damage; set => _damage = value; }

        public  void Attack()
        {
            Console.WriteLine($"{Name} kılıç ile {Damage} şiddetinde atak yaptı.");
        }

        public  void Defense()
        {
            Console.WriteLine($"{Name} kılıç ile savunma yaptı.");
        }
    }
}
