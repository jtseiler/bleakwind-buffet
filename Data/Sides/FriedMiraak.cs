using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
    {
        double price;

        public double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return price = 2.01;
                }
                if (Size == Size.Large)
                {
                    return price = 2.88;
                }
                else return price = 1.78;
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
                    return calories = 236;
                }
                if (Size == Size.Large)
                {
                    return calories = 306;
                }
                else return calories = 151;
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
            return @"""[Size] Fried Miraak"" where [Size] is ""Large"", ""Medium"", or ""Small""";
        }
    }
}
