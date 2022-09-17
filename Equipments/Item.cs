using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Equipments
{
    public enum ISlot
    {
        Weapon,
        Head,
        Body,
        Legs

    }
    public abstract class Item
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public ISlot ISlot { get; set; }

        public Item(string name, int requiredLevel, ISlot iSlot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            ISlot = iSlot;


        }
    }
}
