using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
    {
        double price;

        public double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return price = 1.28;
                }
                if (Size == Size.Large)
                {
                    return price = 1.82;
                }
                else return price = .93;
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
                    return calories = 52;
                }
                if (Size == Size.Large)
                {
                    return calories = 73;
                }
                else return calories = 41;
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
            return @"""[Size] Vokun Salad"" where [Size] is ""Large"", ""Medium"", or ""Small""";
        }
    }
}

