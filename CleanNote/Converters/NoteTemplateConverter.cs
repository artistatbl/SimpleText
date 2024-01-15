using CleanNote.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNote.Converters
{
    public class NoteTemplateConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            try
            {
                var noteType = (int)value;
                var templateType = int.Parse(parameter.ToString());
                return templateType == noteType;
            }
            catch (Exception)
            {

            }


            return false;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
