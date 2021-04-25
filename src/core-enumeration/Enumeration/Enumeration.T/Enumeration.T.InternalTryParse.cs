#nullable enable

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        private static bool InternalTryGet(TEnumeration actual, out TEnumeration result)
        {
            // TODO: Implement to return a normalized value from the set

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
