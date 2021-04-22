#nullable enable

using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        internal static class EnumerationSet
        {
            public static IReadOnlySet<TEnumeration> Value => Internal.Value;

            private static class Internal
            {
                public static IReadOnlySet<TEnumeration> Value = Build();

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                private static IReadOnlySet<TEnumeration> Build()
                    =>
                    EnumerationSource<TEnumeration>.Value.ToHashSet();
            }
        }
    }
}
