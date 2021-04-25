#nullable enable

namespace System
{
    partial class Enumeration
    {
        public static Enumeration<TEnumeration> With<TEnumeration>(Func<string, TEnumeration> factory)
            where TEnumeration : struct
        {
            _ = factory ?? throw new ArgumentNullException(nameof(factory));

            return Enumeration<TEnumeration>.With(factory);
        }
    }
}
