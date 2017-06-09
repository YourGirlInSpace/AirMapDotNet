using System;
using System.Runtime.Serialization;

namespace AirMapDotNet.Authentication
{
    /// <summary>
    /// Represents an authentication error of some kind.
    /// </summary>
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
        public AuthenticationException(string message)
            : base(message)
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
    }
}