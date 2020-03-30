namespace WeaponShopV20
{
    public class Sword : Weapon
    {
        public const int InitialSwordMinDamage = 30;
        public const int InitialSwordMaxDamage = 100;
        public Sword(string description, int weight) : base(description, weight, InitialSwordMinDamage, InitialSwordMaxDamage)
        {
        }
        public override int DealDamage()
        {
            int damage = base.DealDamage();
            if( Weight >5)
            {
                damage = base.DealDamage() /2;
            }
            MinDamage = MinDamage < 10 ? 0 : MinDamage - 10;
            MaxDamage = MaxDamage < 10 ? 0 : MaxDamage - 10;

            return damage;
        }
          public void Sharpen()
        {
            MinDamage = InitialSwordMinDamage * 2;
            MaxDamage = InitialSwordMaxDamage * 2;
        } 
    }
}