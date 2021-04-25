#nullable enable

namespace System
{
    internal interface IEnumeration<TEnumeration>
        where TEnumeration : struct
    {
        bool TryGetValue(TEnumeration equalValue, out TEnumeration actualValue);
    }
}
