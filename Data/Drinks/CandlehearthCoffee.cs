using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        double price;

        public double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return price = 1.25;
                }
                if (Size == Size.Large)
                {
                    return price = 1.75;
                }
                else return price = .75;
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
                    return calories = 10;
                }
                if (Size == Size.Large)
                {
                    return calories = 20;
                }
                else return calories = 7;
            }
        }

        public bool Ice { get; set; } = false;

        public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; } = false;


        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (RoomForCream) instructions.Add("Add cream");
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        public override string ToString()
        {
            return @"""[Size] Candlehearth Coffee"" when thhe coffee is caffinated, or ""[Size] Decaf Candlehhearth Coffee"" when it is decaffinated, and for both[Size] is ""Large"", ""Medium"", or ""Small""";
        }
    }
}
