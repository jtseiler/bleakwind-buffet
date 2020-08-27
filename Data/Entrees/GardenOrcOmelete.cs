using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelete
    {
        public double Price => 4.57;

        public uint Calories => 404;

        public bool Broccoli { get; set; } = true;

        public bool Mushroom { get; set; } = true;

        public bool Tomato { get; set; } = true;

        public bool Cheddar { get; set; } = true;


        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli;");
                if (!Mushroom) instructions.Add("Hold mushroom;");
                if (!Tomato) instructions.Add("Hold tomato;");
                if (!Cheddar) instructions.Add("Hold cheddar;");
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Garden Orc Omelete";
        }
    }
}
