#nullable enable

using System.Runtime.CompilerServices;

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool InternalTryNormalize(TEnumeration actual, out TEnumeration normalized)
            =>
            EnumerationSet.Value.TryGetValue(actual, out normalized);
    }
}
