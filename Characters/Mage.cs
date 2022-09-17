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


    }
}
