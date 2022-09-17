﻿using RPG_Heroes.Attributes;
using RPG_Heroes.Equipments;
using System.Text;

namespace RPG_Heroes.Characters
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int LevelAttributes;
        public HeroAttribute heroAttribute { get; set; }
        public Dictionary<ISlot, Item> Equipments { get; set; }
        public List<WeaponType> ValidWeaponTypes { get; set; }
        public List<ArmorType> ValidArmorTypes { get; set; }

        public Hero(string name, int strength, int dexterity, int intelligence)
        {
            Name = name;
            Level = 1;
            Equipments = new Dictionary<ISlot, Item>();
            ValidWeaponTypes = new List<WeaponType>();
            ValidArmorTypes = new List<ArmorType>();

            Equipments = new Dictionary<ISlot, Item>()
            {
                {ISlot.Weapon, null! },
                {ISlot.Body, null! },
                {ISlot.Legs, null! },
                {ISlot.Head, null! }
            };
            heroAttribute = new HeroAttribute()
            {
                Strength = strength,
                Dexterity = dexterity,
                Intelligence = intelligence
            };

        } 


        public int TotalAttributes()
        {
            Armor BodyArmor = (Armor)Equipments[ISlot.Body];
            Armor HeadArmor = (Armor)Equipments[ISlot.Head];
            Armor LegsArmor = (Armor)Equipments[ISlot.Legs];

            int total = 0;
            if (BodyArmor != null)
            {
                total += BodyArmor.ArmorAttribute.SumOfAttribute();
            }
            if (HeadArmor != null)
            {
                total += HeadArmor.ArmorAttribute.SumOfAttribute();
            }
            if (LegsArmor != null)
            {
                total += LegsArmor.ArmorAttribute.SumOfAttribute();
            }

            return total + LevelAttributes;
        }

        public string Display()
        {
            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.Append($"Name: {Name}/n");
            stringbuilder.Append($"Level: {Level}/n");
            stringbuilder.Append($"Strenght: {heroAttribute.Strength}/n");
            stringbuilder.Append($"Dexterity: {heroAttribute.Dexterity}/n");
            stringbuilder.Append($"Intelligence: {heroAttribute.Intelligence}/n");
            stringbuilder.Append($"Damage: {Damage}");
            return stringbuilder.ToString();
        }



        public abstract bool EquipWeapon(Weapon weapon);

        public abstract bool EquipArmor(Armor armor);

        public abstract void LevelUp();

        public abstract double Damage();


    }
}
     
