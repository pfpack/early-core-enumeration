#nullable enable

using static System.Optional;

namespace System
{
    partial class Enumeration
    {
        public static Optional<TEnumeration> Parse<TEnumeration>(string value, Func<string, TEnumeration> map)
            where TEnumeration : struct
        {
            _ = value ?? throw new ArgumentNullException(nameof(value));
            _ = map ?? throw new ArgumentNullException(nameof(map));

            return Enumeration<TEnumeration>.TryParse(value, map, out var result)
                ? Present(result)
                : default;
        }
    }
}
