using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDesk.Models
{
    public class Exceptions
    {
        // The user's input is wrong. The message is shown to them as-is.
        public class ValidationException : Exception
        {
            public ValidationException(string message) : base(message) { }
            public ValidationException(string message, Exception inner) : base(message, inner) { }
        }

        // A business rule was broken (not enough quantity, duplicate name...). The message is shown as-is.
        public class BusinessRuleException : Exception
        {
            public BusinessRuleException(string message) : base(message) { }
            public BusinessRuleException(string message, Exception inner) : base(message, inner) { }
        }

        // A database or system problem. The message is user-friendly,
        // the technical details stay in InnerException and go to the log.
        public class DataAccessException : Exception
        {
            public DataAccessException(string message, Exception inner) : base(message, inner) { }
            public DataAccessException(string messgae) : base(messgae) { }
        }

    }
}
