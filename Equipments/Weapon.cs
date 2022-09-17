using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Equipments
{
    public enum WeaponType
    {
        Axes,
        Bows,
        Daggers,
        Hammers,
        Staffs,
        Swords,
        Wands

    }
    public class Weapon : Item
    {
        public WeaponType WeaponType { get; set; }
        public double WeaponDamage { get; set; }


        public Weapon(string Name, int requiredLevel, WeaponType weaponType, double weaponDamage) : base(Name, requiredLevel, 0)
        {
            WeaponDamage = weaponDamage;
            WeaponType = weaponType;
                
        }
    }
}
