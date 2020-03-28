using System;

namespace SalesWebMvc2017.Services.Exceptions
{
    public class IntegretyException : ApplicationException
    {
        public IntegretyException(string message) : base(message)
        {
        }
    }
}
