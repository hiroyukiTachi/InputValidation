using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MyValidation
{
    /// <summary>
    /// URL検証クラス
    /// </summary>
    class UrlValidationHandler : ValidationHandler
    {

        protected override bool execValidation(string input)
        {
            return Regex.IsMatch(input, @"\As?https?://[-_.!~*'()a-zA-Z0-9;/?:@&=+$,%#]+\z");
        }

        protected override string getErrorMessage()
        {
            return "URLを入力してください";
        }

    }
}
