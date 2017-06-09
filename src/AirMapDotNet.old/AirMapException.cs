using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Security.Permissions;
using AirMapDotNet.Entities;

namespace AirMapDotNet
{
    /// <summary>
    /// The exception that is thrown when an error occurs during an interaction with the AirMap API.
    /// </summary>
    [Serializable]
    public class AirMapException : Exception
    {
        /// <summary>
        /// The status code sent from the AirMap API.
        /// </summary>
        /// <value>A <see cref="JSendStatus"/> representation of the AirMap API response data's "status" property.</value>
        /// <remarks>
        ///     <para>The status code is determined from the JSend specification.</para>
        ///     <para>
        ///         <list type="table">
        ///             <item>
        ///                 <term><see cref="JSendStatus.Success"/></term>
        ///                 <description>All went well, and (usually) some data was returned.</description>
        ///             </item>
        ///             <item>
        ///                 <term><see cref="JSendStatus.Fail"/></term>
        ///                 <description>There was a problem with the data submitted, or some pre-condition of the API call wasn't satisfied.</description>
        ///             </item>
        ///             <item>
        ///                 <term><see cref="JSendStatus.Error"/></term>
        ///                 <description>An error occurred in processing the request, i.e. an exception was thrown.</description>
        ///             </item>
        ///         </list>
        ///     </para>
        ///     <para>
        ///         Additionally, the <see cref="JSendStatus"/> contains an <see cref="JSendStatus.Unknown"/> value which
        ///         represents a state in which either the status property was not set, or it does not apply.
        ///     </para>
        /// </remarks>
        public JSendStatus Status { get; } = JSendStatus.Unknown;
        

        /// <summary>
        /// A list of the fields which caused the exception.
        /// </summary>
        public Collection<NameMessagePair> Errors { get; }

        /// <summary>
        /// Initializes a new instance of the AirMapException class.
        /// </summary>
        public AirMapException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Exception class with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        public AirMapException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AirMapException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public AirMapException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AirMapException class with a status code..
        /// </summary>
        /// <param name="status">A <see cref="JSendStatus"/> representation of the resultant status property.</param>
        public AirMapException(JSendStatus status)
        {
            Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the Exception class with a specified error message and a status code..
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        /// <param name="status">A <see cref="JSendStatus"/> representation of the resultant status property.</param>
        public AirMapException(string message, JSendStatus status)
            : base(message)
        {
            Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the AirMapException class with a specified error message, a status code and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        /// <param name="status">A <see cref="JSendStatus"/> representation of the resultant status property.</param>
        public AirMapException(string message, JSendStatus status, Exception inner)
            : base(message, inner)
        {
            Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the AirMapException class.
        /// </summary>
        /// <param name="data">A representation of the fields that caused the error and how they failed.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="data"/> is null.</exception>
        public AirMapException(AirMapErrorData data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Errors = data.Errors;
        }

        /// <summary>
        /// Initializes a new instance of the Exception class with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        /// <param name="data">A representation of the fields that caused the error and how they failed.</param>
        public AirMapException(string message, AirMapErrorData data)
            : base(message)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Errors = data.Errors;
        }

        /// <summary>
        /// Initializes a new instance of the AirMapException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        /// <param name="data">A representation of the fields that caused the error and how they failed.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public AirMapException(string message, AirMapErrorData data, Exception inner)
            : base(message, inner)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Errors = data.Errors;
        }

        /// <summary>
        /// Initializes a new instance of the AirMapException class with a status code..
        /// </summary>
        /// <param name="status">A <see cref="JSendStatus"/> representation of the resultant status property.</param>
        /// <param name="data">A representation of the fields that caused the error and how they failed.</param>
        public AirMapException(JSendStatus status, AirMapErrorData data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Status = status;
            Errors = data.Errors;
        }

        /// <summary>
        /// Initializes a new instance of the Exception class with a specified error message and a status code..
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        /// <param name="status">A <see cref="JSendStatus"/> representation of the resultant status property.</param>
        /// <param name="data">A representation of the fields that caused the error and how they failed.</param>
        public AirMapException(string message, JSendStatus status, AirMapErrorData data)
            : base(message)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Status = status;
            Errors = data.Errors;
        }

        /// <summary>
        /// Initializes a new instance of the AirMapException class with a specified error message, a status code and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        /// <param name="data">A representation of the fields that caused the error and how they failed.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        /// <param name="status">A <see cref="JSendStatus"/> representation of the resultant status property.</param>
        public AirMapException(string message, JSendStatus status, AirMapErrorData data, Exception inner)
            : base(message, inner)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Status = status;
            Errors = data.Errors;
        }

        /// <summary>
        /// Initializes a new instance of the AirMapException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="info"/> parameter is <b>null</b>.</exception>
        /// <exception cref="SerializationException">The class name is <b>null</b> or <see cref="Exception.HResult"/> is zero (0).</exception>
        protected AirMapException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
            Status = (JSendStatus?) info.GetValue("Status", typeof(JSendStatus)) ?? throw new ArgumentNullException(nameof(info));
            Errors = (Collection<NameMessagePair>) info.GetValue("Errors", typeof(Collection<NameMessagePair>));
        }

        /// <summary>
        /// Sets the <see cref="SerializationInfo" /> with information about the <see cref="AirMapException"/>.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="info" /> parameter is a null reference.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter" />
        /// </PermissionSet>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            info.AddValue("Status", Status);
            info.AddValue("Errors", Errors);

            base.GetObjectData(info, context);
        }
    }
}