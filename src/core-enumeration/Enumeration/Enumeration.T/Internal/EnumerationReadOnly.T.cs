#nullable enable

using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System
{
    internal sealed partial class EnumerationReadOnly<TEnumeration>
        where TEnumeration : struct
    {
        private readonly ReadOnlyCollection<TEnumeration> values;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EnumerationReadOnly(ReadOnlyCollection<TEnumeration> values)
            =>
            this.values = values;

        public ReadOnlyCollection<TEnumeration> Values => values;
    }
}
