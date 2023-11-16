using System;
using System.Collections.Generic;

namespace DevExpress.Maui.Demo.Stocks {
    public class MainViewModel {
        public IList<CollectionItemViewModel> Items { get; set; }

        public MainViewModel() {
            Items = new List<CollectionItemViewModel>();
            foreach (Symbol symbol in Data.Symbols) {
                var symbolViewModel = new CollectionItemViewModel();
                symbolViewModel.Ticker = symbol.Ticker;
                symbolViewModel.CompanyName = symbol.Name;
                symbolViewModel.Change = symbol.Prices[0].Close - symbol.Prices[1].Close;
                symbolViewModel.ChangePercent = symbol.Prices[0].Close / symbol.Prices[1].Close - 1;
                symbolViewModel.Date = symbol.Prices[0].Date;
                symbolViewModel.ClosePrice = symbol.Prices[0].Close;
                Items.Add(symbolViewModel);
            }
        }
    }

    public class CollectionItemViewModel {
        public string Ticker { get; set; }
        public string CompanyName { get; set; }
        public double ClosePrice { get; set; }
        public double Change { get; set; }
        public double ChangePercent { get; set; }
        public DateTime Date { get; set; }
    }
}