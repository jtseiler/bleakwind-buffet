/*
 * Author: Jack Seiler
 * Class name: Menu.cs
 * Purpose: gives details of the menu
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

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
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries db = new DragonbornWaffleFries();
                FriedMiraak fm = new FriedMiraak();
                MadOtarGrits mog = new MadOtarGrits();
                VokunSalad vs = new VokunSalad();
                db.Size = size;
                fm.Size = size;
                mog.Size = size;
                vs.Size = size;
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
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice aa = new AretinoAppleJuice();
                CandlehearthCoffee cc = new CandlehearthCoffee();
                MarkarthMilk mm = new MarkarthMilk();
                WarriorWater ww = new WarriorWater();
                aa.Size = size;
                cc.Size = size;
                mm.Size = size;
                ww.Size = size;
                drinks.Add(aa);
                drinks.Add(cc);
                drinks.Add(mm);
                drinks.Add(ww);
                foreach (SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = size;
                    ss.Flavor = flavor;
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
            foreach (IOrderItem entree in Entrees())
            {
                all.Add(entree);
            }
            foreach (IOrderItem side in Sides())
            {
                all.Add(side);
            }
            foreach (IOrderItem drink in Drinks())
            {
                all.Add(drink);
            }
            return all;
        }
    }
}