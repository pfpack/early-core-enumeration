#nullable enable

using static System.Optional;

namespace System
{
    partial class EnumerationExtensions
    {
        public static Optional<TEnumeration> Parse<TEnumeration>(this Enumeration<TEnumeration> enumeration, string value)
            where TEnumeration : struct
        {
            _ = enumeration ?? throw new ArgumentNullException(nameof(enumeration));
            _ = value ?? throw new ArgumentNullException(nameof(value));

            return enumeration.TryParse(value, out var result)
                ? Present(result)
                : default;
        }
    }
}
