using Class05.Interfaces;
using Class05.Models;

namespace Class05
{
    class Program
    {
        static void Main(string[] args)
        {
            IArmor chestArmor = new Chainmail("Old Chainmail armor", 7);
            IWeapon crossBow = new Bow("Crossbow", 4);

            IArmor armor = new Leather("Elven Leather Armor", 12);
            IWeapon sword = new Sword("Long sword", 5);

            ICombatant hero = new Fighter("Noobie Nate", chestArmor, crossBow);
            ICombatant fighter = new Fighter("Fighter Fred", armor, sword);
            ICombatant badGuy = new Fighter("Scary Monster", armor, sword);

            fighter.Attack(badGuy);
            hero.Attack(badGuy);


        }

    }

}
