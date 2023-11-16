using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExpress.Maui.Demo.Stocks {
    public class HistoricalDataViewModel {
        public CollectionItemViewModel Item { get; set; }
        public IList<StockPrice> StockPrices { get; set; }
        public DateTime RangeStart { get; set; }
        public DateTime RangeEnd { get; set; }

        public HistoricalDataViewModel(CollectionItemViewModel items) {
            Item = items;
            Symbol symbol = Data.Symbols.Where(s => s.Ticker == this.Item.Ticker).First();
            RangeStart = symbol.Prices.First().Date;
            RangeEnd = RangeStart.AddDays(-60);
            StockPrices = new List<StockPrice>();
            foreach(StockPrice price in symbol.Prices) {
                StockPrices.Add(price);
            }
        }
    }
}