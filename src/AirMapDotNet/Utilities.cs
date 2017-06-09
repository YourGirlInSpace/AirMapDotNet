using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;

namespace AirMapDotNet
{
    using System.Collections.Specialized;
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
            => GetTypesWithAttribute<T>(typeof(T).GetTypeInfo().Assembly);

        /// <summary>
        /// Gets a list of all types in an <see cref="Assembly"/> with the attribute <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The <see cref="Attribute"/> descendent to search for.</typeparam>
        /// <returns>All types in the current <see cref="Assembly"/> with the attribute <typeparamref name="T"/>.</returns>
        internal static IEnumerable<Type> GetTypesWithAttribute<T>(Assembly asm)
            where T : Attribute => asm.ExportedTypes
        .Where(type => type.GetTypeInfo().GetCustomAttributes<T>(false).Any())
        .Select(type => type);

        internal static double ToRadians(double d)
            => d * (PI / 180.0);

        internal static double ToDegrees(double d)
            => d * (180.0 / PI);

        internal static DateTime DateTimeFromTimestamp(long millis)
            => new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(millis);

        public static string EncodeQuery(Dictionary<string, string> nvc)
        {
            List<string> queryParts = new List<string>();
            foreach (KeyValuePair<string, string> pair in nvc)
            {
                queryParts.Add(pair.Key + "=" + WebUtility.UrlEncode(pair.Value));
            }

            return string.Join("&", queryParts);
        }

        public static Dictionary<string, string> ParseQueryString(string query)
        {
            if (query == null)
                throw new ArgumentNullException(nameof(query));
            if (query.Length == 0 || query.Length == 1 && query[0] == '?')
                return new Dictionary<string, string>();
            if (query[0] == '?')
                query = query.Substring(1);

            Dictionary<string, string> result = new Dictionary<string, string>();
            ParseQueryString(query, result);
            return result;
        }

        internal static void ParseQueryString(string query, Dictionary<string, string> result)
        {
            if (query.Length == 0)
                return;
            
            string decoded = WebUtility.HtmlDecode(query);
            int decodedLength = decoded.Length;
            int namePos = 0;
            bool first = true;
            while (namePos <= decodedLength)
            {
                int valuePos = -1, valueEnd = -1;
                for (int q = namePos; q < decodedLength; q++)
                {
                    if (valuePos == -1 && decoded[q] == '=')
                    {
                        valuePos = q + 1;
                    }
                    else if (decoded[q] == '&')
                    {
                        valueEnd = q;
                        break;
                    }
                }

                if (first)
                {
                    first = false;
                    if (decoded[namePos] == '?')
                        namePos++;
                }

                string name;
                if (valuePos == -1)
                {
                    name = null;
                    valuePos = namePos;
                }
                else
                {
                    name = WebUtility.HtmlDecode(decoded.Substring(namePos, valuePos - namePos - 1));
                }
                if (valueEnd < 0)
                {
                    namePos = -1;
                    valueEnd = decoded.Length;
                }
                else
                {
                    namePos = valueEnd + 1;
                }
                string value = WebUtility.HtmlDecode(decoded.Substring(valuePos, valueEnd - valuePos));

                result.Add(name, value);
                if (namePos == -1)
                    break;
            }
        }
    }
}