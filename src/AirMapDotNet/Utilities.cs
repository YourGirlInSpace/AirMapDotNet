using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AirMapDotNet
{
    using static Math;

    /// <summary>
    /// Provides a set of utilities for this assembly.
    /// </summary>
    internal static class Utilities
    {
        /// <summary>
        /// Gets a list of all types in the <see cref="Assembly"/> with the attribute <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The <see cref="Attribute"/> descendent to search for.</typeparam>
        /// <returns>All types in the current <see cref="Assembly"/> with the attribute <typeparamref name="T"/>.</returns>
        internal static IEnumerable<Type> GetTypesWithAttribute<T>()
            where T : Attribute
            => GetTypesWithAttribute<T>(Assembly.GetExecutingAssembly());

        /// <summary>
        /// Gets a list of all types in an <see cref="Assembly"/> with the attribute <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The <see cref="Attribute"/> descendent to search for.</typeparam>
        /// <returns>All types in the current <see cref="Assembly"/> with the attribute <typeparamref name="T"/>.</returns>
        internal static IEnumerable<Type> GetTypesWithAttribute<T>(Assembly asm)
            where T : Attribute
            => asm.GetTypes().Where(type => type.GetCustomAttributes(typeof(T), true).Length > 0);

        internal static double ToRadians(double d)
            => d * (PI / 180.0);

        internal static double ToDegrees(double d)
            => d * (180.0 / PI);

        internal static DateTime DateTimeFromTimestamp(long millis)
            => new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(millis);
    }
}