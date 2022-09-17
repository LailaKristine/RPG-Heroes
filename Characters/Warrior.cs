using RPG_Heroes.Equipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Characters
{
    internal class Warrior : Hero
    {
        public Warrior(string name ) : base(name, 5, 2, 1)
        {
            ValidArmorTypes.Add(ArmorType.Plate);
            ValidArmorTypes.Add(ArmorType.Mail);
            ValidWeaponTypes.Add(WeaponType.Axes);
            ValidWeaponTypes.Add(WeaponType.Swords);
            ValidWeaponTypes.Add(WeaponType.Hammers);
        }

        public override bool EquipWeapon(Weapon weapon)
        {
            if (weapon.RequiredLevel > Level)
            {
                throw new RequiredLevelException();
            }

            if (ValidWeaponTypes.Contains(weapon.WeaponType))
            {
                Equipments[weapon.ISlot] = weapon;
                return true;
            }
            else
            {
                throw new InvalidWeaponException();
            }

        }
        public override bool EquipArmor(Armor armor)
        {
            if (armor.RequiredLevel > Level)
            {
                throw new RequiredLevelException();
            }
            if (ValidArmorTypes.Contains(armor.ArmorType))
            {
                Equipments[armor.ISlot] = armor;
                return true;
            }
            else
            {
                throw new InvalidWeaponException();
            }

        }
    }
}
