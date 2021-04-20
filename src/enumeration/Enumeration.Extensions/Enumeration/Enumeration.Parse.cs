#nullable enable

using static System.Optional;

namespace System
{
    partial class Enumeration
    {
        public static Optional<TEnumeration> Parse<TEnumeration>(string? value)
            where TEnumeration : struct, IEquatable<TEnumeration>, IEquatable<string>
            =>
            Enumeration<TEnumeration>.TryParse(value, out var result)
                ? Present(result)
                : default;

        public static Optional<TEnumeration> Parse<TEnumeration>(string? value, Func<string?, TEnumeration> map)
            where TEnumeration : struct, IEquatable<TEnumeration>, IEquatable<string>
        {
            _ = map ?? throw new ArgumentNullException(nameof(map));

            return Enumeration<TEnumeration>.TryParse(value, map, out var result)
                ? Present(result)
                : default;
        }
    }
}
