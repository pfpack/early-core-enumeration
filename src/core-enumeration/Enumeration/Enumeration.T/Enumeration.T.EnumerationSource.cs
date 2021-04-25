#nullable enable

using System.Collections.Generic;

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        private static partial class EnumerationSource
        {
            public static IEnumerable<TEnumeration> Value => Internal.Value;

            private static class Internal
            {
                public static IEnumerable<TEnumeration> Value = Builder.Build();
            }
        }
    }
}
