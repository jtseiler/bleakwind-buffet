using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
    {
        double price;

        public double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return price = 1.11;
                }
                if (Size == Size.Large)
                {
                    return price = 1.22;
                }
                else return price = 1.05;
            }
        }

        public Size Size { get; set; } = Size.Small;

        uint calories;

        public uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return calories = 72;
                }
                if (Size == Size.Large)
                {
                    return calories = 93;
                }
                else return calories = 56;
            }
        }

        public bool Ice { get; set; } = false;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        public override string ToString()
        {
            return @"""[Size] Markarth Milk"" where [Size] is ""Large"", ""Medium"", or ""Small""";
        }
    }
}
