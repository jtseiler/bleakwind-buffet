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

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new DragonbornWaffleFries());
            DragonbornWaffleFries bMed = new DragonbornWaffleFries();
            sideIncrease(bMed, Size.Medium);
            sides.Add(bMed);
            DragonbornWaffleFries bLarge = new DragonbornWaffleFries();
            sideIncrease(bLarge, Size.Large);
            sides.Add(bLarge);

            sides.Add(new FriedMiraak());
            FriedMiraak cMed = new FriedMiraak();
            sideIncrease(cMed, Size.Medium);
            sides.Add(cMed);
            FriedMiraak cLarge = new FriedMiraak();
            sideIncrease(cLarge, Size.Large);
            sides.Add(cLarge);

            sides.Add(new MadOtarGrits());
            MadOtarGrits dMed = new MadOtarGrits();
            sideIncrease(dMed, Size.Medium);
            sides.Add(dMed);
            MadOtarGrits dLarge = new MadOtarGrits();
            sideIncrease(dLarge, Size.Large);
            sides.Add(dLarge);

            sides.Add(new VokunSalad());
            VokunSalad cdMed = new VokunSalad();
            sideIncrease(cdMed, Size.Medium);
            sides.Add(cdMed);
            VokunSalad cdLarge = new VokunSalad();
            sideIncrease(cdLarge, Size.Large);
            sides.Add(cdLarge);
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
            AretinoAppleJuice jMed = new AretinoAppleJuice();
            drinkIncrease(jMed, Size.Medium);
            drinks.Add(jMed);
            AretinoAppleJuice jLarge = new AretinoAppleJuice();
            drinkIncrease(jLarge, Size.Large);
            drinks.Add(jLarge);

            drinks.Add(new CandlehearthCoffee());
            CandlehearthCoffee cMed = new CandlehearthCoffee();
            drinkIncrease(cMed, Size.Medium);
            drinks.Add(cMed);
            CandlehearthCoffee cLarge = new CandlehearthCoffee();
            drinkIncrease(cLarge, Size.Large);
            drinks.Add(cLarge);

            drinks.Add(new MarkarthMilk());
            MarkarthMilk tMed = new MarkarthMilk();
            drinkIncrease(tMed, Size.Medium);
            drinks.Add(tMed);
            MarkarthMilk tLarge = new MarkarthMilk();
            drinkIncrease(tLarge, Size.Large);
            drinks.Add(tLarge);

            drinks.Add(new WarriorWater());
            WarriorWater wMed = new WarriorWater();
            drinkIncrease(wMed, Size.Medium);
            drinks.Add(wMed);
            WarriorWater wLarge = new WarriorWater();
            drinkIncrease(wLarge, Size.Large);
            drinks.Add(wLarge);
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