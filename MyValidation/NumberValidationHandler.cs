using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MyValidation
{
    /// <summary>
    /// 半角数字検証クラス
    /// </summary>
    class NumberValidationHandler : ValidationHandler
    {

        protected override bool execValidation(string input)
        {
            return Regex.IsMatch(input, "^[0-9]+$");
        }

        protected override string getErrorMessage()
        {
            return "半角数字で入力してください";
        }

    }
}
