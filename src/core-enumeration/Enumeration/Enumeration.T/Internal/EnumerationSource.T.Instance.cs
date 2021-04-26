#nullable enable

using System.Runtime.CompilerServices;

namespace System
{
    partial class EnumerationSource<TEnumeration>
    {
        public static EnumerationSource<TEnumeration> Instance => Internal.Instance;

        private static class Internal
        {
            public static readonly EnumerationSource<TEnumeration> Instance = Build();

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static EnumerationSource<TEnumeration> Build()
                =>
                new EnumerationSource<TEnumeration>(EnumerationBuilder<TEnumeration>.Build());
        }
    }
}
