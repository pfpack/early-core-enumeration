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
    }
}
