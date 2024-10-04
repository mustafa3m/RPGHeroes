
using RPGHeroes;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // List of warriors
        List<Warrior> warriors = new List<Warrior>
        {
            new Warrior("Conan"),
            new Warrior("Thor"),
            new Warrior("Hercules"),
            new Warrior("Achilles"),
            new Warrior("Spartacus")
        };

        // Weapons and armor for each warrior
        foreach (var warrior in warriors)
        {
            var axe = new Weapon("Common Axe", 1, WeaponType.Axe, 2);
            var plate = new Armor("Common Plate", 1, ArmorType.Plate, new HeroAttribute(1, 0, 0));

            warrior.Equipment[Slot.Weapon] = axe;
            warrior.Equipment[Slot.Body] = plate;

            // Display the warrior's information
            Console.WriteLine(warrior.Display());
            Console.WriteLine(); // Empty line for better readability
        }
    }
}



