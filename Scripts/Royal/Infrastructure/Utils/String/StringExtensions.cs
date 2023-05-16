using UnityEngine;

namespace Royal.Infrastructure.Utils.String
{
    public static class StringExtensions
    {
        // Methods
        public static string StripHtmlTags(string input)
        {
            return System.Text.RegularExpressions.Regex.Replace(input:  input, pattern:  "^<\\S*\\S>$", replacement:  System.String.alignConst);
        }
        public static string Localize(string text)
        {
            I2.Loc.LocalizedString val_1 = I2.Loc.LocalizedString.op_Implicit(term:  text);
            return (string)I2.Loc.LocalizedString.op_Implicit(s:  new I2.Loc.LocalizedString() {mRTL_IgnoreArabicFix = false, mRTL_ConvertNumbers = false, m_DontLocalizeParameters = false});
        }
        public static string Localize(string text, bool ignoreArabicFix)
        {
            I2.Loc.LocalizedString val_1 = I2.Loc.LocalizedString.op_Implicit(term:  text);
            bool val_4 = ignoreArabicFix;
            return 1376938776;
        }
    
    }

}
