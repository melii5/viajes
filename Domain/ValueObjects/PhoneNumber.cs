using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public partial record PhoneNumber
    {
        private const int length = 9;
        private const string pattern = @"^(?:-*\d-*){8}$";

        private PhoneNumber(string value) => Value = value;

        public string Value { get; init; }

        public static PhoneNumber? Create(string value)
        {
            if (string.IsNullOrEmpty(value) || !PhoneNumberRegex().IsMatch(value) || value.Length != length)
            {
                return null;
            }

            return new PhoneNumber(value);
        }

        [GeneratedRegex(pattern)]
        private static partial Regex PhoneNumberRegex();
    }
}
