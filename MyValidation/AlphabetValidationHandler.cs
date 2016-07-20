using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MyValidation
{
    /// <summary>
    /// 半角英字検証クラス
    /// </summary>
    class AlphabetValidationHandler : ValidationHandler
    {

        protected override bool execValidation(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z]+$");
        }

        protected override string getErrorMessage()
        {
            return "半角英字で入力してください";
        }

    }
}
