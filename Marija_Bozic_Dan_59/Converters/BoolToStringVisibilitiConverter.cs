using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Marija_Bozic_Dan_59.Converters
{
    class BoolToStringVisibilitiConverter: IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            bool isShown =(bool)values[0];
            string name = (string)values[1];
            if (isShown)
            {
                return name;
            }
            return "?";
        }
        public object[] ConvertBack(object value, Type[] targetTypes,
            object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }     
    }
}
