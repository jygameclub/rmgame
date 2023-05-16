using UnityEngine;

namespace I2.Loc
{
    [Serializable]
    public struct LocalizedString
    {
        // Fields
        public string mTerm;
        public bool mRTL_IgnoreArabicFix;
        public int mRTL_MaxLineLength;
        public bool mRTL_ConvertNumbers;
        public bool m_DontLocalizeParameters;
        
        // Methods
        public static string op_Implicit(I2.Loc.LocalizedString s)
        {
            string val_5 = I2.Loc.LocalizationManager.GetTranslation(Term:  mem[s.mTerm], FixForRTL:  ((mem[s.mTerm + 8]) == 0) ? 1 : 0, maxLineLengthForRTL:  mem[s.mTerm + 12], ignoreRTLnumbers:  (s.mTerm.m_stringLength == 0) ? 1 : 0, applyParameters:  true, localParametersRoot:  0, overrideLanguage:  0);
            I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  val_5, allowLocalizedParameters:  ((mem[s.mTerm + 17]) == 0) ? 1 : 0);
            return val_5;
        }
        public static I2.Loc.LocalizedString op_Implicit(string term)
        {
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = term;
            return new I2.Loc.LocalizedString() {mTerm = term, mRTL_IgnoreArabicFix = false, mRTL_ConvertNumbers = false, m_DontLocalizeParameters = false};
        }
        public LocalizedString(I2.Loc.LocalizedString str)
        {
            this.mRTL_ConvertNumbers = mem[str.mTerm];
            mem[1152921528806486520] = ((mem[str.mTerm + 8]) != 0) ? 1 : 0;
            mem[1152921528806486528] = (str.mTerm.m_stringLength != 0) ? 1 : 0;
            mem[1152921528806486524] = mem[str.mTerm + 12];
            mem[1152921528806486529] = ((mem[str.mTerm + 17]) != 0) ? 1 : 0;
        }
        public override string ToString()
        {
            if(W1 < (this.mRTL_ConvertNumbers + 24))
            {
                    bool val_1 = this.mRTL_ConvertNumbers + ((X1) << 3);
                return (string)(this.mRTL_ConvertNumbers + (X1) << 3) + 32;
            }
            
            var val_6 = 0;
            throw new IndexOutOfRangeException();
        }
    
    }

}
