#nullable enable

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        public static bool TryParse(string value, Func<string, TEnumeration> map, out TEnumeration result)
        {
            _ = value ?? throw new ArgumentNullException(nameof(value));
            _ = map ?? throw new ArgumentNullException(nameof(map));

            var actual = map.Invoke(value);

            var matched = ValueSet.Contains(actual);
            result = matched ? actual : default;
            return matched;
        }
    }
}
