#nullable enable

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        public bool TryParse(string value, out TEnumeration result)
        {
            _ = value ?? throw new ArgumentNullException(nameof(value));

            return InternalTryParse(from.Invoke(value), out result);
        }

        private static bool InternalTryParse(TEnumeration actual, out TEnumeration result)
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
