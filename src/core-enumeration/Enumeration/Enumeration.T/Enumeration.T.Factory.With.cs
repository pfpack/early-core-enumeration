#nullable enable

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        public static Enumeration<TEnumeration> With(Func<string, TEnumeration> factory)
        {
            _ = factory ?? throw new ArgumentNullException(nameof(factory));

            return new Enumeration<TEnumeration>(factory);
        }
    }
}
