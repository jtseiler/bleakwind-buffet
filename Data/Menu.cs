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
            sides.Add(new DragonbornWaffleFries());
            DragonbornWaffleFries dbMed = new DragonbornWaffleFries();
            sideIncrease(dbMed, Size.Medium);
            sides.Add(dbMed);
            DragonbornWaffleFries dbLarge = new DragonbornWaffleFries();
            sideIncrease(dbLarge, Size.Large);
            sides.Add(dbLarge);

            sides.Add(new FriedMiraak());
            FriedMiraak fmMed = new FriedMiraak();
            sideIncrease(fmMed, Size.Medium);
            sides.Add(fmMed);
            FriedMiraak fmLarge = new FriedMiraak();
            sideIncrease(fmLarge, Size.Large);
            sides.Add(fmLarge);

            sides.Add(new MadOtarGrits());
            MadOtarGrits mogMed = new MadOtarGrits();
            sideIncrease(mogMed, Size.Medium);
            sides.Add(mogMed);
            MadOtarGrits mogLarge = new MadOtarGrits();
            sideIncrease(mogLarge, Size.Large);
            sides.Add(mogLarge);

            sides.Add(new VokunSalad());
            VokunSalad vsMed = new VokunSalad();
            sideIncrease(vsMed, Size.Medium);
            sides.Add(vsMed);
            VokunSalad vsLarge = new VokunSalad();
            sideIncrease(vsLarge, Size.Large);
            sides.Add(vsLarge);
            return sides;
        }

        /// <summary>
        /// Gets all the drinks
        /// </summary>
        /// <returns>A list of all of the drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new AretinoAppleJuice());
            AretinoAppleJuice aaMed = new AretinoAppleJuice();
            drinkIncrease(aaMed, Size.Medium);
            drinks.Add(aaMed);
            AretinoAppleJuice aaLarge = new AretinoAppleJuice();
            drinkIncrease(aaLarge, Size.Large);
            drinks.Add(aaLarge);

            drinks.Add(new CandlehearthCoffee());
            CandlehearthCoffee ccMed = new CandlehearthCoffee();
            drinkIncrease(ccMed, Size.Medium);
            drinks.Add(ccMed);
            CandlehearthCoffee ccLarge = new CandlehearthCoffee();
            drinkIncrease(ccLarge, Size.Large);
            drinks.Add(ccLarge);

            drinks.Add(new MarkarthMilk());
            MarkarthMilk mmMed = new MarkarthMilk();
            drinkIncrease(mmMed, Size.Medium);
            drinks.Add(mmMed);
            MarkarthMilk mmLarge = new MarkarthMilk();
            drinkIncrease(mmLarge, Size.Large);
            drinks.Add(mmLarge);

            drinks.Add(new WarriorWater());
            WarriorWater wwMed = new WarriorWater();
            drinkIncrease(wwMed, Size.Medium);
            drinks.Add(wwMed);
            WarriorWater wwLarge = new WarriorWater();
            drinkIncrease(wwLarge, Size.Large);
            drinks.Add(wwLarge);
            return drinks;
        }

        /// <summary>
        /// Changes the size of the side
        /// </summary>
        /// <param name="side"></param>
        /// <param name="s"></param>
        public static void sideIncrease(Side side, Size s)
        {
            side.Size = s;
        }

        /// <summary>
        /// Changes the size of the drink
        /// </summary>
        /// <param name="drink"></param>
        /// <param name="s"></param>
        public static void drinkIncrease(Drink drink, Size s)
        {
            drink.Size = s;
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