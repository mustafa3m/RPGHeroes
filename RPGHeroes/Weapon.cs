﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public class Weapon : Item
    {
        public int WeaponDamage { get; set; }
        public WeaponType WeaponType { get; set; }

        public Weapon(string name, int requiredLevel, WeaponType weaponType, int weaponDamage)
            : base(name, requiredLevel, Slot.Weapon)
        {
            WeaponType = weaponType;
            WeaponDamage = weaponDamage;
        }
    }

}
