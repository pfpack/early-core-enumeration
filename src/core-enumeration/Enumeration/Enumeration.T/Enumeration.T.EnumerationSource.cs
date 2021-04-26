#nullable enable

using System.Runtime.CompilerServices;

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        private static IEnumerationSource<TEnumeration> EnumerationSource
            =>
            EnumerationSourceProvider<TEnumeration>.EnumerationSource;
    }
}
