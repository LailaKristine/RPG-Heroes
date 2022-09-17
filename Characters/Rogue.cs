using RPG_Heroes.Equipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Characters
{
    internal class Rogue : Hero
    {
        public Rogue(string name) : base(name, 2, 6, 1)
        {
            ValidArmorTypes.Add(ArmorType.Leather);
            ValidArmorTypes.Add(ArmorType.Mail);
            ValidWeaponTypes.Add(WeaponType.Daggers);
            ValidWeaponTypes.Add(WeaponType.Swords);
        }
    }
}
