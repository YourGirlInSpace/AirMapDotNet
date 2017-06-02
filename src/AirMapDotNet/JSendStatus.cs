namespace AirMapDotNet
{
    /// <summary>
    /// Represents a JSend specification status code.
    /// </summary>
    public enum JSendStatus
    {
        /// <summary>
        /// The status code was not present, or does not apply.
        /// </summary>
        Unknown,
        
        /// <summary>
        /// Represents the status code for "success".
        /// </summary>
        Success,
        
        /// <summary>
        /// Represents the status code for "fail".
        /// </summary>
        Fail,
        
        /// <summary>
        /// Represents the status code for "error".
        /// </summary>
        Error
    }
}