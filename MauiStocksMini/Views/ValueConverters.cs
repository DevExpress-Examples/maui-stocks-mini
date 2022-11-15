using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Graphics;
using System;
using System.Globalization;

namespace DevExpress.Maui.Demo.Stocks {
    public class DoubleToImageSourceConverter : IValueConverter, IMarkupExtension<DoubleToImageSourceConverter> {
        public ImageSource ZeroValue { get; set; } = string.Empty;
        public ImageSource PositiveValue { get; set; } = string.Empty;
        public ImageSource NegativeValue { get; set; } = string.Empty;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (!(value is double doubleValue) || targetType != typeof(ImageSource)) return null;
            switch (doubleValue) {
                case > 0: return PositiveValue;
                case < 0: return NegativeValue;
                default: return ZeroValue;
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotSupportedException();
        }

        public object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }

        DoubleToImageSourceConverter IMarkupExtension<DoubleToImageSourceConverter>.ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }

    public class DoubleToColorConverter : IValueConverter, IMarkupExtension<DoubleToColorConverter>{
        public string ZeroValue { get; set; } = string.Empty;
        public string PositiveValue { get; set; } = string.Empty;
        public string NegativeValue { get; set; } = string.Empty;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (!(value is double doubleValue) || targetType != typeof(Color)) return null;
            switch (doubleValue) {
                case > 0: return (Color)Application.Current.Resources[PositiveValue];
                case < 0: return (Color)Application.Current.Resources[NegativeValue];
                default: return (Color)Application.Current.Resources[ZeroValue];
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotSupportedException();
        }

        public DoubleToColorConverter ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
}
