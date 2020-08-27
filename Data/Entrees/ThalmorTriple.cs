using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        public double Price => 8.32;

        public uint Calories => 943;

        public bool Ketchup { get; set; } = true;

        public bool Bun { get; set; } = true;

        public bool Mustard { get; set; } = true;

        public bool Pickle { get; set; } = true;

        public bool Cheese { get; set; } = true;

        public bool Tomato { get; set; } = true;

        public bool Lettuce { get; set; } = true;

        public bool Mayo { get; set; } = true;

        public bool Bacon { get; set; } = true;
       
        public bool Egg { get; set; } = true;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun;");
                if (!Ketchup) instructions.Add("Hold ketchup;");
                if (!Mustard) instructions.Add("Hold mustard;");
                if (!Cheese) instructions.Add("Hold cheese;");
                if (!Pickle) instructions.Add("Hold pickle;");
                if (!Mustard) instructions.Add("Hold tomato;");
                if (!Cheese) instructions.Add("Hold lettuce;");
                if (!Mayo) instructions.Add("Hold mayo;");
                if (!Bacon) instructions.Add("Hold bacon;"); 
                if (!Egg) instructions.Add("Hold egg;");
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
