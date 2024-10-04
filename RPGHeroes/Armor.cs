using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGHeroes;

namespace RPGHeroes
{
    public class Armor : Item
    {
        public ArmorType ArmorType { get; set; }
        public HeroAttribute ArmorAttribute { get; set; }

        public Armor(string name, int requiredLevel, ArmorType armorType, HeroAttribute armorAttribute)
            : base(name, requiredLevel, Slot.Body)  // Example for body armor
        {
            ArmorType = armorType;
            ArmorAttribute = armorAttribute;
        }
    }

}
