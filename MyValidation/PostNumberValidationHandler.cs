using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MyValidation
{
    /// <summary>
    /// 郵便番号検証クラス
    /// </summary>
    class PostNumberValidationHandler : ValidationHandler
    {

        protected override bool execValidation(string input)
        {
            return Regex.IsMatch(input, @"\A\d\d\d-\d\d\d\d\z");
        }

        protected override string getErrorMessage()
        {
            return "郵便番号を入力してください";
        }

    }
}
