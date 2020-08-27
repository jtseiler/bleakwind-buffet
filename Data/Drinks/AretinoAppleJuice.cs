using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        double price;

        public double Price
        {
            get
            {
                if(Size == Size.Medium)
                {
                    return price = .87;
                }
                if (Size == Size.Large)
                {
                    return price = 1.08;
                }
                else return price = .62;
            }
        }

        public Size Size { get; set; } = Size.Small;

        uint calories;

        public uint Calories
        {
            get
            {
                if(Size == Size.Medium)
                {
                    return calories = 88;
                }
                if (Size == Size.Large)
                {
                    return calories = 132;
                }
                else return calories = 44;
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
            return @"""[Size] Aretino Apple Juice"" where [Size] is ""Large"", ""Medium"", or ""Small""";
        }
    }
}
