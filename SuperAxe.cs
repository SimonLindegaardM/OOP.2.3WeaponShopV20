namespace WeaponShopV20
{
    public class SuperAxe : Axe
    {
        
        public SuperAxe(string description, int weight) : base(description, weight)
        {
        }
        public override int DealDamage()
        {
            int damage = base.DealDamage();
            

            MinDamage = MinDamage < 3 ? 0 : MinDamage - 3;
            MaxDamage = MaxDamage < 3 ? 0 : MaxDamage - 3;

            return damage;
        }
        public override void Sharpen()
        {
            MinDamage = InitialAxeMinDamage * 2;
            MaxDamage = InitialAxeMaxDamage * 2;
        } 
    }
}