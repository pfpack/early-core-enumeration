#nullable enable

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace System
{
    internal sealed partial class EnumerationSource<TEnumeration> : IEnumerationSource<TEnumeration>
        where TEnumeration : struct
    {
        private readonly TEnumeration[] values;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private EnumerationSource(TEnumeration[] values)
            =>
            this.values = values;

        public int ValueCount => values.Length;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryGetValue(TEnumeration equalValue, out TEnumeration actualValue)
        {
            for (var i = 0; i < values.Length; i++)
            {
                var currentValue = values[i];

                if (EnumerationComparer.Equals(equalValue, currentValue))
                {
                    actualValue = currentValue;
                    return true;
                }
            }

            actualValue = default;
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlyCollection<TEnumeration> AsReadOnly()
            =>
            values.Pipe(Array.AsReadOnly);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HashSet<TEnumeration> ToHashSet()
            =>
            values.ToHashSet(EnumerationComparer);

        private static IEqualityComparer<TEnumeration> EnumerationComparer
            =>
            EqualityComparer<TEnumeration>.Default;
    }
}
