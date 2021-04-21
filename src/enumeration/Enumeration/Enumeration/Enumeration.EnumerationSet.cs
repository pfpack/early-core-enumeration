#nullable enable

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        private static class EnumerationSet
        {
            public static IReadOnlySet<TEnumeration> Value => Internal.Value;

            private static class Internal
            {
                public static IReadOnlySet<TEnumeration> Value = Build();

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                private static HashSet<TEnumeration> Build()
                    =>
                    new HashSet<TEnumeration>(EnumerationCollection.Value);
            }
        }
    }
}
