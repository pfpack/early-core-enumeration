#nullable enable

using System.Runtime.CompilerServices;

namespace System
{
    partial class EnumerationSet<TEnumeration>
    {
        public static EnumerationSet<TEnumeration> Instance => Internal.Instance;

        private static class Internal
        {
            public static readonly EnumerationSet<TEnumeration> Instance = Build();

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static EnumerationSet<TEnumeration> Build()
                =>
                new EnumerationSet<TEnumeration>(EnumerationSource<TEnumeration>.Instance.ToHashSet());
        }
    }
}
