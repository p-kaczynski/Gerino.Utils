using System;
using System.Runtime.Serialization;

namespace Gerino.Utils.Exceptions
{
    /// <summary>
    ///     When used in code, represents a line that should never be executed, and only exists due to language constrains.
    /// </summary>
    /// <remarks>
    ///     This exception SHOULD NOT be caught.
    /// </remarks>
    [Serializable]
    public class UnreachableCodeException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UnreachableCodeException" /> class.
        /// </summary>
        public UnreachableCodeException()
            : base("This exception is thrown only, if world is seriously broken, or is misused.")
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="UnreachableCodeException" /> class.
        /// </summary>
        /// <param name="info">The information.</param>
        /// <param name="context">The context.</param>
        /// <exception cref="SerializationException">
        ///     The class name is null or <see cref="P:System.Exception.HResult" /> is zero
        ///     (0).
        /// </exception>
        /// <exception cref="ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        protected UnreachableCodeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}