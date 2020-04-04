using System;

namespace MAVN.Service.Campaign.Domain.Extensions
{
    public static class GuidExtensions
    {
        public static Guid ToGuid(this string input)
        {
            if (!Guid.TryParse(input, out var guid))
            {
                throw new ArgumentException("Invalid identifier", nameof(input));
            }

            return guid;
        }
    }
}
