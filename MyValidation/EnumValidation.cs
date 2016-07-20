using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyValidation
{
    /// <summary>
    /// バリデーションタイプ列挙対
    /// </summary>
    public enum ValidateTyle
    {
        Number,
        Alphabet,
        PostNumber,
        PhoneNumber,
        MailAddress,
        Url
    }
    
}
