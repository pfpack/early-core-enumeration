#nullable enable

using System.Runtime.CompilerServices;

namespace System
{
    internal static class EnumerationImpl<TEnumeration>
        where TEnumeration : struct
    {
        public static IEnumeration<TEnumeration> Instance => Internal.Instance;

        private static class Internal
        {
            public static readonly IEnumeration<TEnumeration> Instance = Select();

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static IEnumeration<TEnumeration> Select()
                =>
                EnumerationSource<TEnumeration>.Instance.Count switch
                {
                    > 4 =>
                    EnumerationSet<TEnumeration>.Instance,
                    _ =>
                    EnumerationSource<TEnumeration>.Instance
                };
        }
    }
}
