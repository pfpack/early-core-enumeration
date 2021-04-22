#nullable enable

using System.Collections.Generic;

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        private static IReadOnlySet<TEnumeration> ValueSet => EnumerationSet.Value;
    }
}
