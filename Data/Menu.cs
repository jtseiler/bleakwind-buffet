using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        /// <summary>
        /// Gets all the entrees 
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            return entrees;
        }

        /// <summary>
        /// Gets all of the sides on the menu, is also size specific
        /// </summary>
        /// <returns>A list of all size specific sides on the menu</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            foreach(Size s in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries db = new DragonbornWaffleFries();
                FriedMiraak fm = new FriedMiraak();
                MadOtarGrits mog = new MadOtarGrits();
                VokunSalad vs = new VokunSalad();
                db.Size = s;
                fm.Size = s;
                mog.Size = s;
                vs.Size = s;
                sides.Add(db);
                sides.Add(fm);
                sides.Add(mog);
                sides.Add(vs);
            }
            return sides;
        }

        /// <summary>
        /// Gets all the drinks
        /// </summary>
        /// <returns>A list of all of the drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice aa = new AretinoAppleJuice();
                CandlehearthCoffee cc = new CandlehearthCoffee();
                MarkarthMilk mm = new MarkarthMilk();
                WarriorWater ww = new WarriorWater();
                aa.Size = s;
                cc.Size = s;
                mm.Size = s;
                ww.Size = s;
                drinks.Add(aa);
                drinks.Add(cc);
                drinks.Add(mm);
                drinks.Add(ww);
                foreach (SodaFlavor f in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = s;
                    ss.Flavor = f;
                    drinks.Add(ss);
                }
            }
            return drinks;
        }

        /// <summary>
        /// Gets the whole menu
        /// </summary>
        /// <returns>a list of all items on the menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> all = new List<IOrderItem>();
            foreach (IOrderItem i in Entrees())
            {
                all.Add(i);
            }
            foreach (IOrderItem s in Sides())
            {
                all.Add(s);
            }
            foreach (IOrderItem d in Drinks())
            {
                all.Add(d);
            }
            return all;
        }
    }
}