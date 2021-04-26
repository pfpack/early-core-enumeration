#nullable enable

using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System
{
    internal static class EnumerationReadOnly<TEnumeration>
        where TEnumeration : struct
    {
        public static ReadOnlyCollection<TEnumeration> Values => Internal.Values;

        private static class Internal
        {
            public static readonly ReadOnlyCollection<TEnumeration> Values = Build();

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static ReadOnlyCollection<TEnumeration> Build()
                =>
                EnumerationSource<TEnumeration>.Instance.AsReadOnly();
        }
    }
}
