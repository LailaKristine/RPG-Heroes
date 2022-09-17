using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Attributes
{
    public class HeroAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public HeroAttribute(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        public void LevelAttribute(int LvlUpStrength, int LvlUpDexterity, int LvlUpIntelligence)
        {
            Strength += LvlUpStrength;
            Dexterity += LvlUpDexterity;
            Intelligence += LvlUpIntelligence;
        }
    }
}
