#nullable enable

namespace System
{
    public sealed partial class Enumeration<TEnumeration>
        where TEnumeration : struct
    {
        private readonly Func<string, TEnumeration> from;

        private Enumeration(Func<string, TEnumeration> from)
            =>
            this.from = from;
    }
}
