using UnityEngine;

namespace Royal.Infrastructure.Utils.String
{
    public class AlphanumComparatorFast : IComparer<string>
    {
        // Methods
        public int Compare(string x, string y)
        {
            var val_22;
            var val_23;
            System.Char[] val_24;
            var val_25;
            val_23 = 0;
            int val_19 = 0;
            if(x == 0)
            {
                    return (int)val_23;
            }
            
            if(y == null)
            {
                    return (int)val_23;
            }
            
            val_22 = 0;
            label_29:
            if((val_22 >= y.m_stringLength) || (0 >= (x + 16)))
            {
                goto label_4;
            }
            
            char[] val_3 = new char[0];
            char[] val_4 = new char[0];
            val_24 = val_4;
            var val_24 = 0;
            label_11:
            int val_5 = 1 + val_24;
            val_3[0] = x.Chars[0];
            if(val_5 >= (x + 16))
            {
                goto label_7;
            }
            
            val_24 = val_24 + 1;
            if(((System.Char.IsDigit(c:  x.Chars[val_5])) ^ (System.Char.IsDigit(c:  val_3[0]))) == false)
            {
                goto label_11;
            }
            
            label_7:
            var val_25 = 0;
            val_25 = 0;
            val_25 = val_25 + val_24;
            val_25 = val_25 + 1;
            label_18:
            int val_10 = 1 + val_25;
            val_24[0] = y.Chars[0];
            if(val_10 >= y.m_stringLength)
            {
                goto label_14;
            }
            
            val_25 = val_25 + 1;
            if(((System.Char.IsDigit(c:  y.Chars[val_10])) ^ (System.Char.IsDigit(c:  val_24[0]))) == false)
            {
                goto label_18;
            }
            
            label_14:
            string val_15 = 0.CreateString(val:  val_3);
            string val_16 = 0.CreateString(val:  val_4);
            if((System.Char.IsDigit(c:  val_3[0])) == false)
            {
                goto label_26;
            }
            
            val_24 = val_24[0];
            if((System.Char.IsDigit(c:  val_24)) == false)
            {
                goto label_26;
            }
            
            bool val_20 = System.Int32.TryParse(s:  val_15, result: out  val_19);
            bool val_21 = System.Int32.TryParse(s:  val_16, result: out  val_19);
            goto label_27;
            label_26:
            val_23 = val_15;
            label_27:
            var val_28 = val_22;
            val_28 = val_28 + val_25;
            val_22 = val_28 + 1;
            if((val_23.CompareTo(strB:  val_16)) == 0)
            {
                goto label_29;
            }
            
            return (int)val_23;
            label_4:
            val_23 = (x + 16) - y.m_stringLength;
            return (int)val_23;
        }
        public AlphanumComparatorFast()
        {
        
        }
    
    }

}
