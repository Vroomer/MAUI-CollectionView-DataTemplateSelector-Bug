using System.Globalization;

namespace MauiApp3;

class NameColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        switch (value)
        {
            case "Red": return Colors.Red;
            case "Green": return Colors.Green;
            case "Blue": return Colors.Blue;
            default: return Colors.Gray;
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
