using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        double price;

        public double Price
        {
            get
            {
                return price = 0;
            }
        }

        public Size Size { get; set; } = Size.Small;

        uint calories;

        public uint Calories
        {
            get
            {
               return calories = 0;
            }
        }

        public bool Ice { get; set; } = false;

        public bool Lemon { get; set; } = false;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("add lemon");
                return instructions;
            }
        }

        public override string ToString()
        {
            return @"""[Size]Warrior Water"" where [Size] is ""Large"", ""Medium"", or ""Small""";
        }
    }
}