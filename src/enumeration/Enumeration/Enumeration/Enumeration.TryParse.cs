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

        public static bool TryParse(string? value, Func<string?, TEnumeration> map, out TEnumeration result)
        {
            _ = map ?? throw new ArgumentNullException(nameof(map));

            var actual = map.Invoke(value);

            var matched = ValueSet.Contains(actual);
            result = matched ? actual : default;
            return matched;
        }
    }
}
