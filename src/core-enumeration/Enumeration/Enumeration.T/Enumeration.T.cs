#nullable enable

namespace System
{
    public sealed partial class Enumeration<TEnumeration>
        where TEnumeration : struct
    {
        private readonly Func<string, TEnumeration> factory;

        private Enumeration(Func<string, TEnumeration> factory)
            =>
            this.factory = factory;
    }
}
