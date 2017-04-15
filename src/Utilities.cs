using System;
using System.Collections.Generic;
using System.Reflection;

namespace AirMapDotNet
{
    internal static class Utilities
    {
        internal static IEnumerable<Type> GetTypesWithAttribute<T>()
            where T : Attribute
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            foreach (Type type in asm.GetTypes())
                if (type.GetCustomAttributes(typeof(T), true).Length > 0)
                    yield return type;
        }
    }
}