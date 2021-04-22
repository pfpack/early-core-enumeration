#nullable enable

using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using static System.Predicates;

namespace System
{
    partial class EnumerationSource<TEnumeration>
    {
        private static class Builder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static TEnumeration[] Build()
                =>
                Enumerate().ToArray();

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static IEnumerable<TEnumeration> Enumerate()
                =>
                Pipeline.Pipe(
                    EnumeratePropertyMatch())
                .Concat(
                    EnumerateFieldMatch());

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static IEnumerable<TEnumeration> EnumeratePropertyMatch()
                =>
                typeof(TEnumeration)
                .GetProperties(Binding.PublicStatic)
                .Where(prop => prop.PropertyType == typeof(TEnumeration))
                .Where(prop => prop.CanRead)
                .Where(prop => prop.CanWrite is false)
                .Select(prop => prop.GetValue(null))
                .Where(IsNotNull)
                .Cast<TEnumeration>();

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static IEnumerable<TEnumeration> EnumerateFieldMatch()
                =>
                typeof(TEnumeration)
                .GetFields(Binding.PublicStatic)
                .Where(field => field.FieldType == typeof(TEnumeration))
                .Where(field => field.IsInitOnly)
                .Select(field => field.GetValue(null))
                .Where(IsNotNull)
                .Cast<TEnumeration>();

            private static class Binding
            {
                public const BindingFlags PublicStatic = BindingFlags.Public | BindingFlags.Static;
            }
        }
    }
}
