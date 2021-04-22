#nullable enable

namespace System
{
    partial class Enumeration<TEnumeration>
    {
        public static TEnumeration Parse(string value, Func<string, TEnumeration> map, Func<TEnumeration> otherFactory)
        {
            _ = value ?? throw new ArgumentNullException(nameof(value));
            _ = map ?? throw new ArgumentNullException(nameof(map));
            _ = otherFactory ?? throw new ArgumentNullException(nameof(otherFactory));

            var actual = map.Invoke(value);

            var matched = ValueSet.Contains(actual);
            return matched ? actual : otherFactory.Invoke();
        }
    }
}
