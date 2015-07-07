using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {

        public IList<Item> Items;
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
                          {
                              Items = new List<Item>
                                          {
                                              new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          }

                          };

            app.UpdateQuality();

            System.Console.ReadKey();

        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                int sellIn = item.SellIn;
                int quality = item.Quality;

                if (item.Name.Contains("Sulfuras"))
                {
                    item.Quality = UpdateLegendaryItem(quality);
                }
                else 
                {
                    item.SellIn = sellIn--;
                    if (item.Name == "Aged Brie")
                    {
                        item.Quality = UpdateAgedItem(sellIn, quality);
                    }
                    else if (item.Name.Contains("Backstage passes"))
                    {
                        item.Quality = UpdateBackstagePassItem(sellIn, quality);
                    }
                    else if (item.Name.Contains("Conjured"))
                    {
                        item.Quality = UpdateConjuredItem(sellIn, quality);
                    }
                    else
                    {
                        item.Quality = UpdateRegularItem(sellIn, quality);
                    }
                }
                

            }

        }

        public bool IsPastSellIn(int sellIn)
        {
            if(sellIn < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool IsHighestQuality(int quality)
        {
            if(quality >= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsLowestQuality(int quality)
        {
            if(quality == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public int UpdateRegularItem(int sellIn, int quality)
        {
            if(!IsLowestQuality(quality))
            {
                if (sellIn < 0)
                {
                    quality = quality - 2;
                }
                else
                {
                    quality = quality - 1;
                }
            }

            if (quality < 0)
            {
                quality = 0;
            }

            return quality;
        }

        public int UpdateLegendaryItem(int quality)
        {
            return quality;
        }

        public int UpdateConjuredItem(int sellIn, int quality)
        {
            int qualityDegrade = 2;

            if (!IsLowestQuality(quality))
            {
                if (IsPastSellIn(sellIn))
                {
                    qualityDegrade = qualityDegrade * 2;
                }
                quality = quality - qualityDegrade;
                if(quality < 0)
                {
                    quality = 0;
                }
            }
            
          
            return quality;
        }

        public int UpdateBackstagePassItem(int sellIn, int quality)
        {
            if(sellIn < 0)
            {
                quality = 0;
            }
            else if(!IsHighestQuality(quality))
            {
                if (sellIn < 6)
                {
                    quality = quality + 3;
                }
                else if (sellIn < 11)
                {
                    quality = quality + 2;
                }
            }
            if(quality > 50)
            {
                quality = 50;
            }
            return quality;
        }

        public int UpdateAgedItem(int sellIn, int quality)
        {
            if (!IsHighestQuality(quality))
            {
                quality++;
            }
            return quality;
        }

}


        public class Item
        {
            public string Name { get; set; }

            public int SellIn { get; set; }

            public int Quality { get; set; }
        }

    }

