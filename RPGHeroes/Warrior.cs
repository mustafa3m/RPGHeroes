using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGHeroes;

namespace RPGHeroes
{
    public class Warrior : Hero
    {
        public Warrior(string name)
            : base(name, new HeroAttribute(5, 2, 1)) { }

        public override List<WeaponType> ValidWeaponTypes => new List<WeaponType> { WeaponType.Axe, WeaponType.Hammer, WeaponType.Sword };
        public override List<ArmorType> ValidArmorTypes => new List<ArmorType> { ArmorType.Mail, ArmorType.Plate };

        public override void LevelUp()
        {
            Level++;
            LevelAttributes += new HeroAttribute(3, 2, 1);
        }

        protected override int GetMainAttribute() => TotalAttributes().Strength;

        public void Equip(Item item)
        {
            if (item is Weapon weapon)
            {
                Equipment[Slot.Weapon] = weapon;
            }
            else if (item is Armor armor)
            {
                Equipment[armor.Slot] = armor; // Assuming armor has a Slot property
            }
            else
            {
                throw new InvalidOperationException("Item type not supported.");
            }
        }

    }

}
