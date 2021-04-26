#nullable enable

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System
{
    internal sealed partial class EnumerationSet<TEnumeration> : IEnumerationSource<TEnumeration>
        where TEnumeration : struct
    {
        private readonly HashSet<TEnumeration> values;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EnumerationSet(HashSet<TEnumeration> values)
            =>
            this.values = values;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryGetValue(TEnumeration equalValue, out TEnumeration actualValue)
            =>
            values.TryGetValue(equalValue, out actualValue);
    }
}
