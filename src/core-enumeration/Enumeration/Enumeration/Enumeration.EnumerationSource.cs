#nullable enable

using System.Collections.Generic;

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        private static partial class EnumerationSource
        {
            public static IReadOnlyCollection<TEnumeration> Value => Internal.Value;

            private static class Internal
            {
                public static IReadOnlyCollection<TEnumeration> Value = Builder.Build();
            }
        }
    }
}
