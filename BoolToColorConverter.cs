using System;
using System.Globalization;
using Xamarin.Forms;

namespace SelectableButtons
{
    public class BoolToColorConverter :  IValueConverter
    {
       
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var flag = (bool)value;
            string colorFor = (string)parameter;

            switch (colorFor)
            {
                case "SelectionIndicator":
                    return flag ? Color.Green : Color.Yellow;
                case "Background":
                    return flag ? Color.Red : Color.Blue;
                default:
                    return Color.Transparent;
            }
                      
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
