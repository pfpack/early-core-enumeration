#nullable enable

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        private static bool InternalTryGet(TEnumeration actual, out TEnumeration result)
        {
            if (EnumerationSet.Value.Contains(actual))
            {
                result = actual;
                return true;
            }

            result = default;
            return false;
        }
    }
}
