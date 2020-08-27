using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        double price;

        public double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return price = 1.74;
                }
                if (Size == Size.Large)
                {
                    return price = 2.07;
                }
                else return price = 1.42;
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
                    return calories = 153;
                }
                if (Size == Size.Large)
                {
                    return calories = 205;
                }
                else return calories = 117;
            }
        }

        public bool Ice { get; set; } = false;

        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        public override string ToString()
        {
            return @"""[Size][Flavor] Sailor Soda"" where [Size] is ""Large"", ""Medium"", or ""Small"" and [Flavor] is ""Blackberry"", ""Cherry"", ""Grapefruit"", ""Lemon"", ""Peach"", or ""Watermellon""";
        }
    }
}
