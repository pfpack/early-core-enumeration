#nullable enable

using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        private static class EnumerationCollection
        {
            public static ReadOnlyCollection<TEnumeration> Value => Internal.Value;

            private static class Internal
            {
                public static ReadOnlyCollection<TEnumeration> Value = Build();

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                private static ReadOnlyCollection<TEnumeration> Build()
                    =>
                    EnumerationSource<TEnumeration>.Value.ToArray().Pipe(Array.AsReadOnly);
            }
        }
    }
}
