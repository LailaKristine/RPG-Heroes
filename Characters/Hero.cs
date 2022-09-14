using RPG_Heroes.Attributes;
using RPG_Heroes.Equipments;

namespace RPG_Heroes.Characters
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public HeroAttribute LevelAttributes { get; set; }
        List<Weapon> ValidWeaponTypes { get; set; }
        List<Armor> ValidArmorTypes { get; set; }

        public Hero(string name, int strength, int dexterity, int intelligence)
        {
            Name = name;
            Level = 1;
            LevelAttributes = new HeroAttribute()
            {
                Strength = strength,
                Dexterity = dexterity,
                Intelligence = intelligence
            };
        }
    }
}
     
