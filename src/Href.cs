using System;
using System.Collections.Specialized;
using System.Web;
using AirMapDotNet.Entities;
using Newtonsoft.Json;

namespace AirMapDotNet
{
    /// <summary>
    /// Represents a link to an AirMap API resource.
    /// </summary>
    public class Href : IEquatable<Href>
    {
        /// <summary>
        /// The URI where the resource may be found.
        /// </summary>
        [JsonProperty("href")]
        public Uri Uri { get; }

        /// <summary>
        /// Creates a new <see cref="Href"/> with an empty <see cref="Uri"/>.
        /// </summary>
        public Href()
        {
        }

        /// <summary>
        /// Creates a new <see cref="Href"/> with the specified URI.
        /// </summary>
        /// <param name="uri">The value to assign to <see cref="Uri"/></param>
        public Href(Uri uri)
        {
            Uri = uri;
        }

        /// <summary>
        /// Compiles the <see cref="Href"/> into a URL.
        /// </summary>
        /// <returns>The compiled URL.</returns>
        public Uri Compile() => Uri;

        /// <summary>
        /// Compiles the <see cref="Href"/> into a URL with the specified query parameters.
        /// </summary>
        /// <param name="parameters">The query parameters to append to the <see cref="Uri"/></param>
        /// <returns>The compiled URL.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="parameters"/> is null.</exception>
        public Uri Compile(NameValueCollection parameters)
        {
            if (parameters == null)
                throw new ArgumentNullException(nameof(parameters));

            UriBuilder uriBuilder = new UriBuilder(Uri);

            NameValueCollection query = HttpUtility.ParseQueryString(uriBuilder.Query);

            foreach (string key in parameters.AllKeys)
                query[key] = parameters[key];

            uriBuilder.Query = query.ToString();

            return uriBuilder.Uri;
        }

        /// <summary>Determines whether the specified object is equal to the current object.</summary>
        /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
        /// <param name="obj">The object to compare with the current object. </param>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Href)obj);
        }

        /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
        /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(Href other)
        {
            if (ReferenceEquals(null, other)) return false;
            return ReferenceEquals(this, other) || string.Equals(Uri, other.Uri);
        }

        /// <summary>Serves as the default hash function. </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode() => Uri?.GetHashCode() ?? 0;

        /// <summary>
        /// Determines whether the current <see cref="Href"/> is equal to another <see cref="Href"/>.
        /// </summary>
        /// <param name="left">The first <see cref="Href"/>.</param>
        /// <param name="right">The second <see cref="Href"/>.</param>
        /// <returns>true if the current <see cref="Href"/> equals the second <see cref="Href"/>.</returns>
        public static bool operator ==(Href left, Href right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Determines whether the current <see cref="Href"/> is not equal to another <see cref="Href"/>.
        /// </summary>
        /// <param name="left">The first <see cref="Href"/>.</param>
        /// <param name="right">The second <see cref="Href"/>.</param>
        /// <returns>true if the current <see cref="Href"/> does not equal the second <see cref="Href"/>.</returns>
        public static bool operator !=(Href left, Href right)
        {
            return !Equals(left, right);
        }
    }

    /// <summary>
    /// Represents a link to an AirMap API resource.
    /// </summary>
    /// <typeparam name="T">The underlying type behind the link.</typeparam>
    public class Href<T> : Href, IEquatable<Href<T>>
        where T : class, IAirMapEntity
    {
        /// <summary>
        /// Creates a new <see cref="Href{T}"/> with an empty <see cref="Uri"/>.
        /// </summary>
        public Href()
        {
        }

        /// <summary>
        /// Creates a new <see cref="Href{T}"/> with the specified URI.
        /// </summary>
        /// <param name="uri">The value to assign to <see cref="Uri"/></param>
        public Href(Uri uri)
            :base(uri)
        { }
        
        /// <summary>Determines whether the specified object is equal to the current object.</summary>
        /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
        /// <param name="obj">The object to compare with the current object. </param>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Href<T>)obj);
        }

        /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
        /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(Href<T> other)
        {
            if (ReferenceEquals(null, other)) return false;
            return ReferenceEquals(this, other) || string.Equals(Uri, other.Uri);
        }

        /// <summary>Serves as the default hash function. </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode() => Uri?.GetHashCode() ?? 0;
        
        /// <summary>
        /// Determines whether the current <see cref="Href{T}"/> is equal to another <see cref="Href{T}"/>.
        /// </summary>
        /// <param name="left">The first <see cref="Href{T}"/>.</param>
        /// <param name="right">The second <see cref="Href{T}"/>.</param>
        /// <returns>true if the current <see cref="Href{T}"/> equals the second <see cref="Href{T}"/>.</returns>
        public static bool operator ==(Href<T> left, Href<T> right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Determines whether the current <see cref="Href{T}"/> is not equal to another <see cref="Href{T}"/>.
        /// </summary>
        /// <param name="left">The first <see cref="Href{T}"/>.</param>
        /// <param name="right">The second <see cref="Href{T}"/>.</param>
        /// <returns>true if the current <see cref="Href{T}"/> does not equal the second <see cref="Href{T}"/>.</returns>
        public static bool operator !=(Href<T> left, Href<T> right)
        {
            return !Equals(left, right);
        }
    }
}