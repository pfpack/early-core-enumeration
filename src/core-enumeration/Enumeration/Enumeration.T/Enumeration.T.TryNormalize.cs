#nullable enable

using System.Runtime.CompilerServices;

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryNormalize(TEnumeration actual, out TEnumeration normalized)
            =>
            EnumerationSet<TEnumeration>.Instance.TryGetValue(actual, out normalized);
    }
}
