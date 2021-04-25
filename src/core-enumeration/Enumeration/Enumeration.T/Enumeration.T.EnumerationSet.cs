#nullable enable

using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        private static class EnumerationSet
        {
            public static IReadOnlyDictionary<TEnumeration, TEnumeration> Value => Internal.Value;

            private static class Internal
            {
                public static IReadOnlyDictionary<TEnumeration, TEnumeration> Value = Build();

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                private static IReadOnlyDictionary<TEnumeration, TEnumeration> Build()
                    =>
                    EnumerationSource.Value
                    .Distinct()
                    .ToDictionary(enumeration => enumeration);
            }
        }
    }
}
