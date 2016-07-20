using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MyValidation
{
    // メールアドレス検証クラス
    class MailAddressValidationHandler : ValidationHandler
    {

        protected override bool execValidation(string input)
        {
            return Regex.IsMatch(input, @"^([a-zA-Z0-9_/\.\-\?\+])+\@([a-zA-Z0-9]+[a-zA-Z0-9\-]*\.)+[a-zA-Z0-9\-]+$");
        }

        protected override string getErrorMessage()
        {
            return "メールアドレスを入力してください";
        }

    }
}
