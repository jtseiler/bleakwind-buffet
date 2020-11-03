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

        public static void sideIncrease(Side obj, Size s)
        {
            obj.Size = s;
        }

        public static void drinkIncrease(Drink obj, Size s)
        {
            obj.Size = s;
        }

        /// <summary>
        /// Searches the menu
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of movies</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> all, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return all;
            foreach (IOrderItem item in all)
            {
                if (item.ToString().Contains(terms))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Gets the possible Category
        /// </summary>
        public static string[] Category
        {
            get => new string[]
            {
            "Entrees",
            "Sides",
            "Drinks"
            };
        }

        /// <summary>
        /// Gets the items within the category selected
        /// </summary>
        /// <param name="all"></param>
        /// <param name="categories"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> all, IEnumerable<string> categories)
        {
            if (categories == null || categories.Count() == 0) return all;
            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (String s in categories)
            {
                if (s.Equals("Entrees"))
                {
                    foreach (IOrderItem i in Entrees())
                    {
                        results.Add(i);
                    }
                }
                else if (s.Equals("Sides"))
                {
                    foreach (IOrderItem side in Sides())
                    {
                        results.Add(side);
                    }
                }
                else if (s.Equals("Drinks"))
                {
                    foreach (IOrderItem d in Drinks())
                    {
                        results.Add(d);
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// Gets the items inbetween the calories filters
        /// </summary>
        /// <param name="all"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> all, int? min, int? max)
        {
            if (min == null && max == null) return all;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem i in all)
                {
                    if (i.Calories <= max) results.Add(i);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem i in all)
                {
                    if (i.Calories >= min) results.Add(i);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem i in all)
            {
                if (i.Calories >= min && i.Calories <= max)
                {
                    results.Add(i);
                }
            }
            return results;
        }

        /// <summary>
        /// Gets the items inbetween the price filters
        /// </summary>
        /// <param name="all"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> all, double? min, double? max)
        {
            if (min == null && max == null) return all;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem i in all)
                {
                    if (i.Price <= max) results.Add(i);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem i in all)
                {
                    if (i.Price >= min) results.Add(i);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem i in all)
            {
                if (i.Price >= min && i.Price <= max)
                {
                    results.Add(i);
                }
            }
            return results;
        }
    }
}