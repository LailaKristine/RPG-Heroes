using RPG_Heroes.Attributes;
using RPG_Heroes.Equipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Characters
{
    internal class Ranger : Hero
    {
        public Ranger(string name) : base(name, 1, 7, 1)
        {
            Name = name;
            ValidArmorTypes.Add(ArmorType.Leather);
            ValidArmorTypes.Add(ArmorType.Mail);
            ValidWeaponTypes.Add(WeaponType.Bows);
            LevelAttributes = 9;
        }

        public override bool EquipWeapon(Weapon weapon)
        {
            if (weapon.RequiredLevel > Level)
            {
                return false;
                throw new RequiredLevelException();
            }

            if (ValidWeaponTypes.Contains(weapon.WeaponType))
            {
                Equipments[weapon.ISlot] = weapon;
                return true;
            }
            else
            {
                return false;
                throw new InvalidWeaponException();
            }


        }
        public override bool EquipArmor(Armor armor)
        {
            if (armor.RequiredLevel > Level)
            {
                return false;
                throw new RequiredLevelException();

            }
            if (ValidArmorTypes.Contains(armor.ArmorType))
            {
                Equipments[armor.ISlot] = armor;
                return true;
            }
            else
            {
                return false;
                throw new InvalidWeaponException();
            }

        }
        public override void LevelUp()
        {
            HeroAttribute LvlUp = new HeroAttribute()
            {
                Strength = this.Level * 1,
                Dexterity = this.Level * 5,
                Intelligence = this.Level * 1
            };
            this.Level = Level + 1;
        }

        public override double Damage()
        {
            if (this.Equipments[ISlot.Weapon] == null)
            {
                return (1 + heroAttribute.Dexterity / 100);
            }
            else
            {
                Weapon weapon = (Weapon)Equipments[ISlot.Weapon];
                return weapon.WeaponDamage * (1 + heroAttribute.Dexterity / 100);
            }
        }
    }
}
