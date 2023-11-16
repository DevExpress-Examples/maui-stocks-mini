using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace DevExpress.Maui.Demo.Stocks {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            var navigationPage = new NavigationPage(new MainPage());
            MainPage = navigationPage;
        }
    }
}
