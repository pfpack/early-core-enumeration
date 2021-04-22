#nullable enable

using System.Collections.Generic;

namespace System
{
    internal static partial class EnumerationSource<TEnumeration>
        where TEnumeration : notnull
    {
        public static IEnumerable<TEnumeration> Value => Internal.Value;

        private static class Internal
        {
            public static IEnumerable<TEnumeration> Value = Builder.Build();
        }
    }
}
