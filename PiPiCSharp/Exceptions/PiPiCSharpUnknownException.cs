namespace PiPiCSharp.Exceptions
{
    using System;

    /// <summary>
    /// The unknown exception.
    /// </summary>
    public class PiPiCSharpUnknownException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpUnknownException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public PiPiCSharpUnknownException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpUnknownException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpUnknownException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
