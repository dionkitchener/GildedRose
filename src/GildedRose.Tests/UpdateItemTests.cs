using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class UpdateItemTests:ItemUpdate
    {
        [Fact]
        public void LegendaryItemDoesNotDecreaseInQuality()
        {
            UpdateItem(TestItems.LegendaryItem);
            Assert.Equal(80, testItem.Quality);
        }

        [Fact]
        public void RegularItemDecreaseQuality()
        {
            UpdateItem(TestItems.RegularItem);
            Assert.Equal(1, testItem.Quality);
        }

        [Fact]
        public void RegularItemDecreasesQualityDoubleAfterSellin()
        {
            UpdateItem(TestItems.RegularItemZeroSellin);
            Assert.Equal(0, testItem.Quality);
        }
        
        [Fact]
        public void RegularItemDecreasesQualityDoubleAfterSellinNotBelowZero()
        {
            UpdateItem(TestItems.RegularItemZeroQuality);
            Assert.Equal(0, testItem.Quality);
        }

        [Fact]
        public void ConjuredItemDegradesTwice()
        {
            UpdateItem(TestItems.ConjuredItemPastSellin);
            Assert.Equal(2, testItem.Quality);
        }

        [Fact]
        public void AgingItemIncreasesQuality()
        {
            UpdateItem(TestItems.AgingItem);
            Assert.Equal(1, testItem.Quality);
        }

        [Fact]
        public void AgingItemCantGoAboveMaxQuality()
        {
            UpdateItem(TestItems.AgingItemHighestQuality);
            Assert.Equal(50, testItem.Quality);
        }

        [Fact]
        public void BackstagePassOverTenDaysLeft()
        {
            UpdateItem(TestItems.BackstagePass);
            Assert.Equal(20, testItem.Quality);
        }

        [Fact]
        public void BackstagePassLessThanTenDaysLeft()
        {
            UpdateItem(TestItems.BackstagePassLessThanTenSellin);
            Assert.Equal(22, testItem.Quality);
        }

        [Fact]
        public void BackstagePassLessThanFiveDaysLeft()
        {
            UpdateItem(TestItems.BackstagePassLessThanFiveSellin);
            Assert.Equal(23, testItem.Quality);
        }

        [Fact]
        public void BackstagePassNoHigherThanMaxQuality()
        {
            UpdateItem(TestItems.BackstagePassHighestQuality);
            Assert.Equal(50, testItem.Quality);
        }

        [Fact]
        public void BackstagePassNoHigherThanMaxQualityBorderline()
        {
            UpdateItem(TestItems.BackstagePassAlmostHighestQuality);
            Assert.Equal(50, testItem.Quality);
        }

        [Fact]
        public void BackstagePassZeroQualityAfterConcert()
        {
            UpdateItem(TestItems.BackstagePassConcertOver);
            Assert.Equal(0, testItem.Quality);
        }


    }
}
