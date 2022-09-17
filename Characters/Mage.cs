using Microsoft.VisualBasic;
using RPG_Heroes.Attributes;
using RPG_Heroes.Equipments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Characters
{
    internal class Mage : Hero
    {
        public  Mage(string name ) : base(name, 1, 1, 8) 
        {
            Name = name;
            ValidArmorTypes.Add(ArmorType.Cloth);
            ValidWeaponTypes.Add(WeaponType.Staffs);
            ValidWeaponTypes.Add(WeaponType.Wands);

            LevelAttributes = 10;

        }

        public override bool EquipWeapon(Weapon weapon)
        {
            bool isEquiped = false;
            if (weapon.RequiredLevel > Level)
            {
                throw new RequiredLevelException();
            }

            if (ValidWeaponTypes.Contains(weapon.WeaponType))
            {
                Equipments[weapon.ISlot] = weapon;
                isEquiped = true;
            }
            else
            {
                throw new InvalidWeaponException();
            }


            if (isEquiped)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override bool EquipArmor(Armor armor)
        {
            bool isEquiped = false;
            if (armor.RequiredLevel > Level)
            {
                throw new RequiredLevelException();

            }
            if (ValidArmorTypes.Contains(armor.ArmorType))
            {
                Equipments[armor.ISlot] = armor;
                isEquiped = true;
            }
            else
            {
                throw new InvalidWeaponException();
            }

            if (isEquiped)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override void LevelUp()
        {
            HeroAttribute LvlUp = new HeroAttribute()
            {
                Strength = this.Level*1,
                Dexterity = this.Level * 1,
                Intelligence = this.Level * 5
            };
            this.Level = Level + 1;
        }

        public override double Damage()
        {
            if (this.Equipments[ISlot.Weapon] == null)
            {
                return (1 + heroAttribute.Intelligence / 100);
            }else
            {
                Weapon weapon = (Weapon)Equipments[ISlot.Weapon];
                return weapon.WeaponDamage * (1 + heroAttribute.Intelligence / 100);
            }
        }
    }
}
