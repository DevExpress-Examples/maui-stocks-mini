using System;
using Android.App;
using Android.Runtime;
using Microsoft.Maui;

namespace DevExpress.Maui.Demo.Stocks
{
	[Application]
	public class MainApplication : MauiApplication
	{
		public MainApplication(IntPtr handle, JniHandleOwnership ownership)
			: base(handle, ownership)
		{
		}
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}