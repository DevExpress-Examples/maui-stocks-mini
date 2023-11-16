using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Maui.Demo.Stocks {
    public class Symbol {
        public string Ticker { get; set; }
        public string Name { get; set; }
        public IList<StockPrice> Prices {  get; set; }
    }
    public class StockPrice {
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Volume { get; set; }
    }
}