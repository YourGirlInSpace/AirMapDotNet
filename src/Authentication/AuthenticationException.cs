using System;
using System.Runtime.Serialization;

namespace AirMapDotNet.Authentication
{
    /// <summary>
    /// Represents an authentication error of some kind.
    /// </summary>
    [Serializable]
    public class AuthenticationException : Exception
    {
        /// <summary>
        /// Creates a new <see cref="AuthenticationException"/>.
        /// </summary>
        public AuthenticationException()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AuthenticationException"/> with a <paramref name="message"/>.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        public AuthenticationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Creates a new <see cref="AuthenticationException"/> with a <paramref name="message"/> and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        /// <param name="inner"></param>
        public AuthenticationException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationException"/> with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="info"/> parameter is <b>null</b>.</exception>
        /// <exception cref="SerializationException">The class name is <b>null</b> or <see cref="Exception.HResult"/> is zero (0).</exception>
        protected AuthenticationException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}