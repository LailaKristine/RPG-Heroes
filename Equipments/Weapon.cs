using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Equipments
{
    internal class Weapon : Item
    {
        internal enum WeaponType
        {
            Axes,
            Bows,
            Daggers,
            Hammers,
            Staffs,
            Swords,
            Wands

        }

        int WeaponDamage;


        public Weapon(string name, int requiredLevel, Slot slot) : base(name, requiredLevel)
        {
            slot = Slot.Weapon;
        }
    }
}
