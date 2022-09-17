using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Equipments
{
    internal class InvalidWeaponException : Exception
    {
        public override string Message => "You cannot equip this Weapon";

    }
}
