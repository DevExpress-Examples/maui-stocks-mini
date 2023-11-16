using Microsoft.Maui.Controls;

namespace DevExpress.Maui.Demo.Stocks {
    public partial class HistoricalDataPage : ContentPage {
        public HistoricalDataPage(HistoricalDataViewModel viewModel) {
            InitializeComponent();
            BindingContext = viewModel;
            Title = viewModel.Item.Ticker;
        }
    }
}