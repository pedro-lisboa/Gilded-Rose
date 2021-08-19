using GildedRoseKata;
using System.Collections.Generic;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void CommunItems()
        {
            var sellIn = 10;
            var quality = 20;

            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
            Assert.Equal(quality - 1, Items[0].Quality);
            Assert.Equal(sellIn - 1, Items[0].SellIn);
        }
        [Fact]
        public void LegendaryItems()
        {
            var sellIn = 0;
            var quality = 80;

            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("Sulfuras, Hand of Ragnaros", Items[0].Name);
            Assert.Equal(quality, Items[0].Quality);
            Assert.Equal(sellIn, Items[0].SellIn);
        }
        [Fact]
        public void ConjuredItems()
        {
            var sellIn = 3;
            var quality = 6;

            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Health Potion", SellIn = 3, Quality = 6 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("Conjured Health Potion", Items[0].Name);
            Assert.Equal(quality - 2, Items[0].Quality);
            Assert.Equal(sellIn - 1, Items[0].SellIn);
        }
        [Fact]
        public void AgedBrieItem()
        {
            var sellIn = 2;
            var quality = 0;

            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("Aged Brie", Items[0].Name);
            Assert.Equal(quality + 1, Items[0].Quality);
            Assert.Equal(sellIn - 1, Items[0].SellIn);
        }
        [Fact]
        public void BackstageItem()
        {
            var sellIn = 2;
            var quality = 0;

            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.Equal(quality + 3, Items[0].Quality);
            Assert.Equal(sellIn - 1, Items[0].SellIn);
        }
        [Fact]
        public void BackstageItemSellInLessThen11()
        {
            var sellIn = 10;
            var quality = 30;

            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.Equal(quality + 2, Items[0].Quality);
            Assert.Equal(sellIn - 1, Items[0].SellIn);
        }
        [Fact]
        public void BackstageItemSellInLessThen6()
        {
            var sellIn = 5;
            var quality = 30;

            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.Equal(quality + 3, Items[0].Quality);
            Assert.Equal(sellIn - 1, Items[0].SellIn);
        }
        [Fact]
        public void BackstageItemExpired()
        {
            var sellIn = 0;
            var quality = 30;

            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.Equal(quality - quality, Items[0].Quality);
            Assert.Equal(sellIn - 1, Items[0].SellIn);
        }
        [Fact]
        public void RegisterItemQualityMoreThen50()
        {
            var sellIn = 10;
            var quality = 152;

            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
            Assert.Equal(50, Items[0].Quality);
            Assert.Equal(sellIn - 1, Items[0].SellIn);
        }
        [Fact]
        public void ItemQualityMax50WithAgedBrie()
        {
            var sellIn = 10;
            var quality = 50;

            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("Aged Brie", Items[0].Name);
            Assert.Equal(50, Items[0].Quality);
            Assert.Equal(sellIn - 1, Items[0].SellIn);
        }
        [Fact]
        public void ItemQualityMax50WithBackstage()
        {
            var sellIn = 10;
            var quality = 50;

            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.Equal(50, Items[0].Quality);
            Assert.Equal(sellIn - 1, Items[0].SellIn);
        }
        [Fact]
        public void RegisterLegendaryItemWithQualityMoreThan80()
        {
            var sellIn = 0;
            var quality = 250;

            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("Sulfuras, Hand of Ragnaros", Items[0].Name);
            Assert.Equal(80, Items[0].Quality);
            Assert.Equal(sellIn, Items[0].SellIn);
        }
        [Fact]
        public void RegisterLegendaryItemWithQualityLessThan80()
        {
            var sellIn = 0;
            var quality = 20;

            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("Sulfuras, Hand of Ragnaros", Items[0].Name);
            Assert.Equal(80, Items[0].Quality);
            Assert.Equal(sellIn, Items[0].SellIn);
        }
        [Fact]
        public void AnyBackstageItem()
        {
            var sellIn = 0;
            var quality = 30;

            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to Rock in Rio", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("Backstage passes to Rock in Rio", Items[0].Name);
            Assert.Equal(quality - quality, Items[0].Quality);
            Assert.Equal(sellIn - 1, Items[0].SellIn);
        }
    }
}
