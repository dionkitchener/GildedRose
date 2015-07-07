using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Console;

namespace GildedRose.Tests
{
    public class ItemUpdate
    {
        protected Item testItem;

        protected void UpdateItem(Item item)
        {
            testItem = item;
            Program testApp = new Program()
            {
                Items = new List<Item>
                {
                    testItem,
                }
            };
            testApp.UpdateQuality();
        }
    }
}
