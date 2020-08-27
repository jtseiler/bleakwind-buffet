using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        double price;

        public double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return price = .76;
                }
                if (Size == Size.Large)
                {
                    return price = .96;
                }
                else return price = .42;
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
                    return calories = 89;
                }
                if (Size == Size.Large)
                {
                    return calories = 100;
                }
                else return calories = 42;
            }
        }


        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        public override string ToString()
        {
            return @"""[Size] Dragonborn Waffle Fries"" where [Size] is ""Large"", ""Medium"", or ""Small""";
        }
    }
}
