namespace KarakterOlustur
{
    public interface IKarakter
    {
        int Id { get; set; }
        string Name { get; set; }
        int Level { get; set; }
        int Damage { get; set; }

        void Attack();
        void Defense();
    }
}
