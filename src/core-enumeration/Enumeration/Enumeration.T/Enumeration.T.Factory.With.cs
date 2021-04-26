#nullable enable

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        public static Enumeration<TEnumeration> With(Func<string, TEnumeration> from)
        {
            _ = from ?? throw new ArgumentNullException(nameof(from));

            return new Enumeration<TEnumeration>(from);
        }
    }
}
