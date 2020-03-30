using System;

namespace WeaponShopV20
{
    public class WeaponTester
    {
        public void Run()
        {
            Console.WriteLine("Running Axe Test...");
            // TestAxe();

            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Running Wand Test...");
            // TestWand();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
            System.Console.WriteLine("Testing my Sword");
            TestSword();
            Console.WriteLine("Running Super Axe Test...");
            // TestSuperAxe();

            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
        }

        private void TestWand()
        {
            Wand myWand = new Wand(" Dragonhair",1);
            UseWeapon(myWand, 5);

            myWand.IsEnchanted = true;
            Console.WriteLine("Enchanted Wand...");
            UseWeapon(myWand, 5);

            myWand.IsEnchanted = false;
            Console.WriteLine("Disenchanted Wand...");
            UseWeapon(myWand, 5);
        }

        private void TestAxe()
        {
            Axe myAxe = new Axe(" Redeemer",4);
            UseWeapon(myAxe, 10);

            myAxe.Sharpen();
            Console.WriteLine("Sharpened Axe...");
            UseWeapon(myAxe, 10);
        }
        private void TestSword()
        {
            Sword mySword = new Sword(" Excalibur",6);
            UseWeapon(mySword,10);

            mySword.Sharpen();
            System.Console.WriteLine("Sharpening my Excalibur!");
            UseWeapon(mySword, 10);
        }
        private void TestSuperAxe()
        {
            Axe mySuperAxe = new SuperAxe(" Redeemer",10);
            UseWeapon(mySuperAxe, 10);

            mySuperAxe.Sharpen();
            Console.WriteLine("Sharpened Axe...");
            UseWeapon(mySuperAxe, 10);
        }

        private void UseWeapon(Weapon theWeapon, int noOfUses)
        {
            System.Console.WriteLine($"Testing Weapon{theWeapon.Description}");
            for (int i =0; i < noOfUses; i++)
            {
                System.Console.WriteLine($"Damage dealt by{ theWeapon.Description}: { theWeapon.DealDamage()}");
            }
            System.Console.WriteLine();
        }
    }
}