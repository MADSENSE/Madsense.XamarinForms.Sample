// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IsSmallerThanParameterConverter.cs" company="polyright SA">
//   Copyright (c) polyright SA. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Globalization;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.Converters
{
    public class IsSmallerThanParameterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return false;

            var doubleParameter = System.Convert.ToDouble(parameter);
            var doubleValue = System.Convert.ToDouble(value);
            if (Math.Abs(doubleValue - doubleParameter) <= double.Epsilon)
            {
                // Equals -> return False
                return false;
            }

            return doubleValue < doubleParameter;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}