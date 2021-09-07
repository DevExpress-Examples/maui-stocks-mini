using Microsoft.Maui.Controls;

namespace DevExpress.Maui.Demo.Stocks {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            Title = "Market"; // https://github.com/dotnet/maui/issues/1658
        }

        private async void DXCollectionView_Tap(object sender, CollectionView.CollectionViewGestureEventArgs e) {
            var symbolViewModel = (CollectionItemViewModel)e.Item;
            var historicalDataViewModel = new HistoricalDataViewModel(symbolViewModel);
            var navigationPage = (NavigationPage)Application.Current.MainPage;
            await navigationPage.PushAsync(new HistoricalDataPage(historicalDataViewModel), false);
        }
    }
}