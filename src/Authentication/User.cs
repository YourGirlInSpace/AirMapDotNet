using System;

namespace AirMapDotNet.Authentication
{
    /// <summary>
    /// Provides a representation of a user account.
    /// </summary>
    public class User
    {
        /// <summary>
        /// The user's Auth0 ID.
        /// </summary>
        public string UserID { get; private set; }

        /// <summary>
        /// The user's email address.
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// The time when the user created the account.
        /// </summary>
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// The time the user was last updated.
        /// </summary>
        /// <remarks>This is almost invariably the time the token was issued.</remarks>
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Creates a new <see cref="User"/> from a <see cref="Auth0.Core.User"/>.
        /// </summary>
        /// <param name="user">The user to copy.</param>
        /// <returns>A new <see cref="User"/> using the parameters from <see cref="Auth0.Core.User"/>.</returns>
        [CLSCompliant(false)]
        public static explicit operator User(Auth0.Core.User user)
        {
            return FromAuth0User(user);
        }

        internal static User FromAuth0User(Auth0.Core.User user)
        {
            return new User
            {
                UserID = user.UserId,
                Email = user.Email,
                CreatedAt = user.CreatedAt,
                UpdatedAt = user.UpdatedAt
            };
        }
    }
}