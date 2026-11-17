using System;
using System.Text.RegularExpressions;

namespace DVLVD_Project
{
    public class clsValidatoin
    {
        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex = new Regex(pattern);
            return regex.IsMatch(emailAddress);
        }

        public static bool ValidateInteger(string Number)
        {
            var pattern = @"^[0-9]+$";
            var regex = new Regex(pattern);
            return regex.IsMatch(Number);
        }

        public static bool ValidateFloat(string Number)
        {
            var pattern = @"^[0-9]+(\.[0-9]+)?$";
            var regex = new Regex(pattern);
            return regex.IsMatch(Number);
        }

        public static bool ValidateNumber(string Number)
        {
            return ValidateInteger(Number);
        }
    }

    // Alias for correct spelling
    public class clsValidation : clsValidatoin
    {
    }
}
