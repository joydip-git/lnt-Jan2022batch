using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException
{
    class AgeLessThanEighteenException : ApplicationException
    {
        private string errorMessage;

        public AgeLessThanEighteenException() { }

        public AgeLessThanEighteenException(string errorMessage)
        {
            this.errorMessage = errorMessage;
        }
        public override string Message => this.errorMessage;
    }
}
