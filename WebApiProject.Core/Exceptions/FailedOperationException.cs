﻿namespace WebApiProject.Core.Exceptions
{
    public class FailedOperationException : Exception
    {
        public FailedOperationException(string message) : base(message)
        {
        }
    }
}
