using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyValidation
{
    /// <summary>
    /// 入力検証実行クラス
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// 入力検証実行
        /// </summary>
        /// <param name="input">検証文字列</param>
        /// <param name="type">バリデーションタイプ</param>
        /// <returns>検証結果メッセージ</returns>
        public static string exec(string input, ValidateTyle type)
        {
            ValidationHandler handler = null;

            switch (type)
            {
                case ValidateTyle.Number:
                    handler = new NumberValidationHandler();
                    break;
                case ValidateTyle.Alphabet:
                    handler = new AlphabetValidationHandler();
                    break;
                case ValidateTyle.PostNumber:
                    handler = new PostNumberValidationHandler();
                    break;
                case ValidateTyle.PhoneNumber:
                    handler = new PhoneNumberValidationHandler();
                    break;
                case ValidateTyle.MailAddress:
                    handler = new MailAddressValidationHandler();
                    break;
                case ValidateTyle.Url:
                    handler = new UrlValidationHandler();
                    break;
            }

            return handler.validate(input);
        }

    }
}
