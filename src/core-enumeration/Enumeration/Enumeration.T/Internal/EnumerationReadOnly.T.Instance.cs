#nullable enable

using System.Runtime.CompilerServices;

namespace System
{
    partial class EnumerationReadOnly<TEnumeration>
    {
        public static EnumerationReadOnly<TEnumeration> Instance => Internal.Instance;

        private static class Internal
        {
            public static readonly EnumerationReadOnly<TEnumeration> Instance = Build();

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static EnumerationReadOnly<TEnumeration> Build()
                =>
                new EnumerationReadOnly<TEnumeration>(EnumerationSource<TEnumeration>.Instance.AsReadOnly());
        }
    }
}
