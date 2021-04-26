#nullable enable

namespace System
{
    internal interface IEnumerationSource<TEnumeration>
        where TEnumeration : struct
    {
        bool TryGetValue(TEnumeration equalValue, out TEnumeration actualValue);
    }
}
