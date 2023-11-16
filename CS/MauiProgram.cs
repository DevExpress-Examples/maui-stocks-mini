using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using DevExpress.Maui.CollectionView;
using DevExpress.Maui.Charts;

[assembly: XamlCompilationAttribute(XamlCompilationOptions.Compile)]

namespace DevExpress.Maui.Demo.Stocks
{
	public class MauiProgram
	{
		public static MauiApp CreateMauiApp() {

			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.UseDevExpress()
				.ConfigureFonts(fonts => {
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});

			return builder.Build();
		}
	}
}