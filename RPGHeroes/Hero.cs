using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public HeroAttribute LevelAttributes { get; set; }
        public Dictionary<Slot, Item> Equipment { get; set; }
        public abstract List<WeaponType> ValidWeaponTypes { get; }
        public abstract List<ArmorType> ValidArmorTypes { get; }

        public Hero(string name, HeroAttribute levelAttributes)
        {
            Name = name;
            LevelAttributes = levelAttributes;
            Equipment = new Dictionary<Slot, Item>
        {
            { Slot.Weapon, null },
            { Slot.Head, null },
            { Slot.Body, null },
            { Slot.Legs, null }
        };
        }

        public abstract void LevelUp();

        public HeroAttribute TotalAttributes()
        {
            HeroAttribute total = LevelAttributes;

            foreach (var item in Equipment.Values)
            {
                if (item is Armor armor)
                {
                    total += armor.ArmorAttribute;
                }
            }

            return total;
        }

        public virtual double Damage()
        {
            var weapon = Equipment[Slot.Weapon] as Weapon;
            int mainAttribute = GetMainAttribute();
            double weaponDamage = weapon != null ? weapon.WeaponDamage : 1;

            return weaponDamage * (1 + (mainAttribute / 100.0));
        }

        protected abstract int GetMainAttribute();

        public string Display()
        {
            var totalAttributes = TotalAttributes();
            return $"Name: {Name}\nClass: {this.GetType().Name}\nLevel: {Level}\n" +
                   $"Strength: {totalAttributes.Strength}\nDexterity: {totalAttributes.Dexterity}\n" +
                   $"Intelligence: {totalAttributes.Intelligence}\nDamage: {Damage():F2}";

        }
    }

}
