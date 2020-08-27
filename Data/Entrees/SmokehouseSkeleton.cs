using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        public double Price => 5.62;

        public uint Calories => 602;

        public bool SausageLink { get; set; } = true;

        public bool Egg { get; set; } = true;

        public bool Hashbrowns { get; set; } = true;

        public bool Pancake { get; set; } = true;


        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sauasage;");
                if (!Egg) instructions.Add("Hold egg;");
                if (!Hashbrowns) instructions.Add("Hold hashbrown;");
                if (!Pancake) instructions.Add("Hold pancakes;");
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
