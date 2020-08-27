using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {
        double price;

        public double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return price = 1.58;
                }
                if (Size == Size.Large)
                {
                    return price = 1.93;
                }
                else return price = 1.22;
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
                    return calories = 142;
                }
                if (Size == Size.Large)
                {
                    return calories = 179;
                }
                else return calories = 105;
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
            return @"""[Size] Mad Otar Grits"" where [Size] is ""Large"", ""Medium"", or ""Small""";
        }
    }
}
