using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.CustomValidation
{
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid( object value )
        {
            DateTime futureTime;
            var isValid = DateTime.TryParseExact( value.ToString(),
                "HH:mm",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out futureTime );

            return ( isValid && futureTime > DateTime.Now );

        }
    }
}