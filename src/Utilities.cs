using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

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
            where T : Attribute => GetTypesWithAttribute<T>(Assembly.GetExecutingAssembly());

        /// <summary>
        /// Gets a list of all types in an <see cref="Assembly"/> with the attribute <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The <see cref="Attribute"/> descendent to search for.</typeparam>
        /// <returns>All types in the current <see cref="Assembly"/> with the attribute <typeparamref name="T"/>.</returns>
        internal static IEnumerable<Type> GetTypesWithAttribute<T>(Assembly asm)
            where T : Attribute
        {
            foreach (Type type in asm.GetTypes())
                if (type.GetCustomAttributes(typeof(T), true).Length > 0)
                    yield return type;
        }

        internal static double ToRadians(double d)
        {
            return d * (PI / 180.0);
        }

        internal static double ToDegrees(double d)
        {
            return d * (180.0 / PI);
        }

        internal static double Add(ref double location1, double value)
        {
            double newCurrentValue = location1; // non-volatile read, so may be stale
            while (true)
            {
                double currentValue = newCurrentValue;
                double newValue = currentValue + value;
                newCurrentValue = Interlocked.CompareExchange(ref location1, newValue, currentValue);
                if (Abs(newCurrentValue - currentValue) < double.Epsilon)
                    return newValue;
            }
        }
    }
}