using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyValidation
{
    /// <summary>
    /// 検証用抽象クラス
    /// </summary>
    abstract class ValidationHandler
    {

        private const string SUCCESS_MESSAGE = "Success!";
        private ValidationHandler nextHandler;

        public ValidationHandler()
        {
            nextHandler = null;
        }

        public ValidationHandler setHandler(ValidationHandler handler)
        {
            nextHandler = handler;
            return this;
        }

        public ValidationHandler getNextHandler()
        {
            return nextHandler;
        }

        public string validate(string input)
        {
            bool result = execValidation(input);

            if (!result)
            {
                return getErrorMessage();
            }
            else if (getNextHandler() != null)
            {
                return getNextHandler().validate(input);
            }
            else
            {
                return SUCCESS_MESSAGE;
            }

        }

        protected abstract bool execValidation(string input);

        protected abstract string getErrorMessage();

    }
}
