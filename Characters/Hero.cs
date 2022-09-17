using RPG_Heroes.Attributes;
using RPG_Heroes.Equipments;

namespace RPG_Heroes.Characters
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public HeroAttribute LevelAttributes { get; set; }
        public Dictionary<ISlot, Item> Equipments { get; set; }
        public List<Weapon> ValidWeaponTypes { get; set; }
        public List<Armor> ValidArmorTypes { get; set; }

        public Hero(string name, int strength, int dexterity, int intelligence)
        {
            Name = name;
            Level = 1;
            Equipments = new Dictionary<ISlot, Item>()
            {
                {ISlot.Weapon, null! },
                {ISlot.Body, null! },
                {ISlot.Legs, null! },
                {ISlot.Head, null! }
            };

        }
    }
}
     
