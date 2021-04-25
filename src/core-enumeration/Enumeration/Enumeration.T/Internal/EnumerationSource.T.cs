#nullable enable

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System
{
    internal sealed partial class EnumerationSource<TEnumeration>
        where TEnumeration : struct
    {
        private readonly TEnumeration[] values;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private EnumerationSource(TEnumeration[] values)
            =>
            this.values = values;

        public IReadOnlyCollection<TEnumeration> Values => values;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlyCollection<TEnumeration> AsReadOnly()
            =>
            new ReadOnlyCollection<TEnumeration>(values);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HashSet<TEnumeration> ToHashSet()
            =>
            new HashSet<TEnumeration>(values);
    }
}
