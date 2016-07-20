using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MyValidation
{
    /// <summary>
    /// 電話番号検証クラス
    /// </summary>
    class PhoneNumberValidationHandler : ValidationHandler
    {

        protected override bool execValidation(string input)
        {
            return Regex.IsMatch(input, @"\A0\d{1,4}-\d{1,4}-\d{4}\z");
        }

        protected override string getErrorMessage()
        {
            return "電話番号を入力してください";
        }

    }
}
