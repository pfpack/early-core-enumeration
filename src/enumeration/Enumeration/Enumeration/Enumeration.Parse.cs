#nullable enable

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        public static bool TryParse(string? value, out TEnumeration result)
        {
            foreach (var current in Values)
            {
                if (current.Equals(value))
                {
                    result = current;
                    return true;
                }
            }

            result = default;
            return false;
        }

        public static TEnumeration Parse(string? value, Func<string?, TEnumeration> otherFactory)
        {
            _ = otherFactory ?? throw new ArgumentNullException(nameof(otherFactory));

            foreach (var current in Values)
            {
                if (current.Equals(value))
                {
                    return current;
                }
            }

            return otherFactory.Invoke(value);
        }
    }
}
