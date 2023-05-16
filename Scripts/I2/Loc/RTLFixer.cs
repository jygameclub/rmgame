using UnityEngine;

namespace I2.Loc
{
    public class RTLFixer
    {
        // Methods
        public static string Fix(string str)
        {
            return I2.Loc.RTLFixer.Fix(str:  str, showTashkeel:  false, useHinduNumbers:  true);
        }
        public static string Fix(string str, bool rtl)
        {
            string val_14;
            string val_15;
            if(rtl != false)
            {
                    return I2.Loc.RTLFixer.Fix(str:  str, showTashkeel:  false, useHinduNumbers:  true);
            }
            
            char[] val_1 = new char[1];
            val_1[0] = 32;
            int val_14 = val_2.Length;
            val_14 = "";
            if(val_14 >= 1)
            {
                    var val_15 = 0;
                val_14 = val_14 & 4294967295;
                val_15 = val_14;
                do
            {
                if(((System.String.IsNullOrEmpty(value:  1152921505165333712)) != true) && ((System.Char.IsLower(c:  1152921505165333712.ToLower().Chars[((System.String[].__il2cppRuntimeField_name < 0) ? (System.String[].__il2cppRuntimeField_name + 1) : System.String[].__il2cppRuntimeField_name) >> 1])) != false))
            {
                    val_14 = "";
                val_15 = val_15 + I2.Loc.RTLFixer.Fix(str:  val_14, showTashkeel:  false, useHinduNumbers:  true)(I2.Loc.RTLFixer.Fix(str:  val_14, showTashkeel:  false, useHinduNumbers:  true)) + 1152921505165333712 + " ";
            }
            else
            {
                    val_14 = val_14 + 1152921505165333712 + " ";
            }
            
                val_15 = val_15 + 1;
            }
            while(val_15 < (val_2.Length << ));
            
            }
            else
            {
                    val_15 = val_14;
            }
            
            if((System.String.op_Inequality(a:  val_14, b:  "")) == false)
            {
                    return val_15;
            }
            
            return val_15 + I2.Loc.RTLFixer.Fix(str:  val_14, showTashkeel:  false, useHinduNumbers:  true)(I2.Loc.RTLFixer.Fix(str:  val_14, showTashkeel:  false, useHinduNumbers:  true));
        }
        public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
        {
            string val_17;
            var val_18;
            string val_19;
            string val_20;
            val_17 = str;
            string val_1 = I2.Loc.HindiFixer.Fix(text:  val_17);
            if((System.String.op_Inequality(a:  val_1, b:  val_17)) != false)
            {
                    return val_1;
            }
            
            val_18 = null;
            val_18 = null;
            I2.Loc.RTLFixerTool.showTashkeel = showTashkeel;
            I2.Loc.RTLFixerTool.useHinduNumbers = useHinduNumbers;
            val_19 = "\n";
            val_20 = System.Environment.NewLine;
            if((val_17.Contains(value:  "\n")) != false)
            {
                    val_17 = val_17.Replace(oldValue:  "\n", newValue:  val_20);
                val_20 = System.Environment.NewLine;
            }
            
            if((val_17.Contains(value:  val_20)) == false)
            {
                    return I2.Loc.RTLFixerTool.FixLine(str:  val_17);
            }
            
            string[] val_10 = new string[1];
            val_19 = System.Environment.NewLine;
            val_10[0] = val_19;
            System.String[] val_12 = val_17.Split(separator:  val_10, options:  0);
            if((val_12.Length == 0) || (val_12.Length == 1))
            {
                    return I2.Loc.RTLFixerTool.FixLine(str:  val_17);
            }
            
            if(val_12.Length < 2)
            {
                    return val_1;
            }
            
            do
            {
                var val_14 = 5 - 4;
                string val_17 = I2.Loc.RTLFixerTool.FixLine(str:  val_12[0])(I2.Loc.RTLFixerTool.FixLine(str:  val_12[0])) + System.Environment.NewLine + I2.Loc.RTLFixerTool.FixLine(str:  val_12[1])(I2.Loc.RTLFixerTool.FixLine(str:  val_12[1]));
                var val_19 = 5 + 1;
            }
            while((5 - 3) < val_12.Length);
            
            return val_1;
        }
        public RTLFixer()
        {
        
        }
    
    }

}
