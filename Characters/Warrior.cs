using RPG_Heroes.Attributes;
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
            Name = name;
            ValidArmorTypes.Add(ArmorType.Plate);
            ValidArmorTypes.Add(ArmorType.Mail);
            ValidWeaponTypes.Add(WeaponType.Axes);
            ValidWeaponTypes.Add(WeaponType.Swords);
            ValidWeaponTypes.Add(WeaponType.Hammers);
            LevelAttributes = 8;
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
                Strength = this.Level * 3,
                Dexterity = this.Level * 2,
                Intelligence = this.Level * 1
            };
            this.Level = Level + 1;
        }

        public override double Damage()
        {
            if (this.Equipments[ISlot.Weapon] == null)
            {
                return (1 + heroAttribute.Strength / 100);
            }
            else
            {
                Weapon weapon = (Weapon)Equipments[ISlot.Weapon];
                return weapon.WeaponDamage * (1 + heroAttribute.Strength / 100);
            }
        }
    }
}
