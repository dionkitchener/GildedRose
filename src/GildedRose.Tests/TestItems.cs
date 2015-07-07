using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Console;

namespace GildedRose.Tests
{
    public static class TestItems
    {
        public static Item RegularItem
        {
            get { return new Item { Name = "Example Item", SellIn = 2, Quality = 2 }; }
        }
        public static Item RegularItemZeroSellin
        {
            get { return new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 2 }; }
        }
        public static Item RegularItemPastSellin
        {
            get { return new Item { Name = "Elixir of the Mongoose", SellIn = -1, Quality = 2 }; }
        }
        public static Item RegularItemOneQuality
        {
            get { return new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 1 }; }
        }
        public static Item RegularItemZeroQuality
        {
            get { return new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 0 }; }
        }
        public static Item LegendaryItem
        {
            get { return new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 }; }
        }
        public static Item ConjuredItem
        {
            get { return new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }; }
        }
        public static Item ConjuredItemZeroSellin
        {
            get { return new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 6 }; }
        }
        public static Item ConjuredItemPastSellin
        {
            get { return new Item { Name = "Conjured Mana Cake", SellIn = -1, Quality = 6 }; }
        }
        public static Item ConjuredItemOneQuality
        {
            get { return new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 1 }; }
        }

        public static Item AgingItem
        {
            get { return new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 }; }
        }
        public static Item AgingItemHighestQuality
        {
            get { return new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 }; }
        }

        public static Item BackstagePass
        {
            get
            {
                return new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                };
            }

        }

        public static Item BackstagePassLessThanTenSellin
        {
            get
            {
                return new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 9,
                    Quality = 20
                };
            }

        }

        public static Item BackstagePassLessThanFiveSellin
        {
            get
            {
                return new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 4,
                    Quality = 20
                };
            }

        }

        public static Item BackstagePassHighestQuality
        {
            get
            {
                return new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 4,
                    Quality = 50
                };
            }

        }
        public static Item BackstagePassAlmostHighestQuality
        {
            get
            {
                return new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 4,
                    Quality = 49
                };
            }

        }

        public static Item BackstagePassSellinZero
        {
            get
            {
                return new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 0,
                    Quality = 20
                };
            }

        }

        public static Item BackstagePassConcertOver
        {
            get
            {
                return new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = -1,
                    Quality = 20
                };
            }

        }


    }
}
