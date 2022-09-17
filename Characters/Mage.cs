using RPG_Heroes.Equipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Characters
{
    internal class Mage : Hero
    {
        public  Mage(string name ) : base(name, 1, 1, 8) 
        {
            ValidArmorTypes.Add(ArmorType.Cloth);
            ValidWeaponTypes.Add(WeaponType.Staffs);
            ValidWeaponTypes.Add(WeaponType.Wands);

        }

        public override bool EquipWeapon(Weapon weapon)
        {
            if(weapon.RequiredLevel>Level)
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

        public override void LeveUp()
        {

        }

    }
}
