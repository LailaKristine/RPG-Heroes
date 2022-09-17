using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Heroes.Attributes;

namespace RPG_Heroes.Equipments
{
    public enum ArmorType
    {
        Cloth,
        Leather,
        Mail,
        Plate

    }
    public class Armor : Item
    {
        public ArmorType ArmorType { get; set; }
        public HeroAttribute ArmorAttribute { get; set; }

        public Armor(ArmorType armorType, HeroAttribute heroAttribute, ISlot slot, string Name, int requiredLevel) : base(Name, requiredLevel, slot)
        {
            ArmorType = armorType;
            ArmorAttribute = heroAttribute;
        }
    }
}
