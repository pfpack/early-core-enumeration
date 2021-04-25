#nullable enable

using System.Runtime.CompilerServices;

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryNormalize(TEnumeration actual, out TEnumeration normalized)
            =>
            EnumerationSource<TEnumeration>.Instance.Count switch
            {
                > 4 =>
                EnumerationSet<TEnumeration>.Instance.TryGetValue(actual, out normalized),

                _ =>
                EnumerationSource<TEnumeration>.Instance.TryGetValue(actual, out normalized)
            };
    }
}
