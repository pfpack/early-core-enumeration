#nullable enable

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        private static bool InternalTryNormalize(TEnumeration actual, out TEnumeration normalized)
            =>
            EnumerationSet.Value.TryGetValue(actual, out normalized);
    }
}
