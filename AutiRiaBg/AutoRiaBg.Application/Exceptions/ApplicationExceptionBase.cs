namespace AutoRiaBg.Application.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public abstract class ApplicationExceptionBase : Exception
    {
        // CS8632 Disables waring about nullable.
#pragma warning disable CS8632
        public ApplicationExceptionBase()  : base() { }
        public ApplicationExceptionBase(string? message) : base(message) { }
        public ApplicationExceptionBase(string? message, Exception? innerException) : base (message, innerException) { }
#pragma warning restore CS8632 

    }
}
