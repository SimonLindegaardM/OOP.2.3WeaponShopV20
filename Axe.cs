namespace WeaponShopV20
{
    /// <summary>
    /// This class represents a Axe. An Axe is 
    /// considered to be a weapon.
    /// </summary>
    public class Axe : Weapon
    {
        public const int InitialAxeMinDamage = 20;
        public const int InitialAxeMaxDamage = 50;

        #region Constructor
        public Axe(string description, int weight) : base(description, weight, InitialAxeMinDamage, InitialAxeMaxDamage)
        {
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the damage dealt by the Axe. Also lowers the
        /// minimum and maximum damage dealt by three points.
        /// </summary>
        public override int DealDamage()
        {
            int damage = base.DealDamage();
            if( Weight >5)
            {
                damage = base.DealDamage() /2;
            }
            MinDamage = MinDamage < 3 ? 0 : MinDamage - 3;
            MaxDamage = MaxDamage < 3 ? 0 : MaxDamage - 3;

            return damage;
        }

        /// <summary>
        /// Resets the minimum and maximum damage dealt by 
        /// the Axe to its original values.
        /// </summary>
        public virtual void Sharpen()
        {
            MinDamage = InitialAxeMinDamage;
            MaxDamage = InitialAxeMaxDamage;
        } 
        #endregion
    }
}