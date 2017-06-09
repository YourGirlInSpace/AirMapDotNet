using System;

namespace AirMapDotNet.Authentication
{
    /// <summary>
    /// Provides a representation of a user account.
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// The user's Auth0 ID.
        /// </summary>
        string UserID { get; }

        /// <summary>
        /// The user's email address.
        /// </summary>
        string Email { get; }

        /// <summary>
        /// The time when the user created the account.
        /// </summary>
        DateTime CreatedAt { get; }

        /// <summary>
        /// The time the user was last updated.
        /// </summary>
        /// <remarks>This is almost invariably the time the token was issued.</remarks>
        DateTime UpdatedAt { get; }
    }
}