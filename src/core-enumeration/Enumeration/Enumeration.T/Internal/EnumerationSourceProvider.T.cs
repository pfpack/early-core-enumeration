#nullable enable

using System.Runtime.CompilerServices;

namespace System
{
    internal static class EnumerationSourceProvider<TEnumeration>
        where TEnumeration : struct
    {
        public static IEnumerationSource<TEnumeration> EnumerationSource => Internal.EnumerationSource;

        private static class Internal
        {
            public static readonly IEnumerationSource<TEnumeration> EnumerationSource = Select();

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static IEnumerationSource<TEnumeration> Select()
                =>
                EnumerationSource<TEnumeration>.Instance.ValueCount switch
                {
                    > 4 =>
                    EnumerationSet<TEnumeration>.Instance,
                    _ =>
                    EnumerationSource<TEnumeration>.Instance
                };
        }
    }
}
