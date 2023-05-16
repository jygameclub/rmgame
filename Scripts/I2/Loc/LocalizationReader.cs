using UnityEngine;

namespace I2.Loc
{
    public class LocalizationReader
    {
        // Methods
        public static System.Collections.Generic.Dictionary<string, string> ReadTextAsset(UnityEngine.TextAsset asset)
        {
            var val_16;
            System.StringComparer val_17;
            string val_8 = 0;
            string val_9 = 0;
            System.Byte[] val_2 = asset.bytes;
            System.Byte[] val_3 = asset.bytes;
            System.IO.StringReader val_6 = new System.IO.StringReader(s:  System.Text.Encoding.UTF8.Replace(oldValue:  "\r\n", newValue:  "\n").Replace(oldValue:  "\r", newValue:  "\n"));
            val_16 = null;
            val_16 = null;
            val_17 = System.StringComparer._ordinal;
            System.Collections.Generic.Dictionary<System.String, System.String> val_7 = new System.Collections.Generic.Dictionary<System.String, System.String>(comparer:  val_17);
            if(val_6 == null)
            {
                    return val_7;
            }
            
            do
            {
                if((I2.Loc.LocalizationReader.TextAsset_ReadLine(line:  val_6, key: out  val_8, value: out  val_9, category: out  0, comment: out  0, termType: out  0)) != false)
            {
                    val_17 = val_8;
                if((System.String.IsNullOrEmpty(value:  val_17)) != true)
            {
                    if((System.String.IsNullOrEmpty(value:  val_9)) != true)
            {
                    val_7.set_Item(key:  val_17, value:  val_9);
            }
            
            }
            
            }
            
            }
            while(val_6 != null);
            
            return val_7;
        }
        public static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType)
        {
            int val_23;
            var val_24;
            var val_25;
            var val_26;
            val_23 = 1152921528759412448;
            val_24 = 1152921528759404352;
            val_25 = line;
            key = System.String.alignConst;
            category = System.String.alignConst;
            comment = System.String.alignConst;
            termType = System.String.alignConst;
            value = System.String.alignConst;
            string val_23 = "//";
            int val_1 = val_25.LastIndexOf(value:  val_23);
            if((val_1 & 2147483648) == 0)
            {
                    val_23 = val_1 + 2;
                string val_3 = val_25.Substring(startIndex:  val_23).Trim();
                comment = val_3;
                comment = I2.Loc.LocalizationReader.DecodeString(str:  val_3);
                val_25 = val_25.Substring(startIndex:  0, length:  val_1);
            }
            
            int val_6 = val_25.IndexOf(value:  "=");
            if((val_6 & 2147483648) == 0)
            {
                    val_23 = val_6;
                key = val_25.Substring(startIndex:  0, length:  val_23).Trim();
                string val_11 = val_25.Substring(startIndex:  val_23 + 1).Trim();
                value = val_11;
                string val_13 = val_11.Replace(oldValue:  "\r\n", newValue:  "\n").Replace(oldValue:  "\n", newValue:  "\\n");
                value = val_13;
                value = I2.Loc.LocalizationReader.DecodeString(str:  val_13);
                if((val_8.m_stringLength >= 3) && ((key.Chars[0] & 65535) == '['))
            {
                    int val_17 = key.IndexOf(value:  ']');
                if((val_17 & 2147483648) == 0)
            {
                    val_24 = val_17;
                termType = key.Substring(startIndex:  1, length:  val_24 - 1);
                key = key.Substring(startIndex:  val_24 + 1);
            }
            
            }
            
                I2.Loc.LocalizationReader.ValidateFullTerm(Term: ref  string val_22 = key);
                val_26 = 1;
                return (bool)val_26;
            }
            
            val_26 = 0;
            return (bool)val_26;
        }
        public static string ReadCSVfile(string Path, System.Text.Encoding encoding)
        {
            var val_4;
            System.IO.StreamReader val_1 = null;
            val_4 = val_1;
            val_1 = new System.IO.StreamReader(path:  Path, encoding:  encoding);
            var val_4 = 0;
            if(mem[1152921504640217088] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    System.IO.StreamReader val_2 = 1152921504640180224 + ((mem[1152921504640217096]) << 4);
            }
            
            val_1.Dispose();
            if(0 != 0)
            {
                    throw 0;
            }
            
            if(val_4 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_4 = "\n";
            string val_3 = val_1.Replace(oldValue:  "\r\n", newValue:  "\n");
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            return val_3.Replace(oldValue:  "\r", newValue:  "\n");
        }
        public static System.Collections.Generic.List<string[]> ReadCSV(string Text, char Separator = '\x2c')
        {
            System.Collections.Generic.List<System.String[]> val_1 = new System.Collections.Generic.List<System.String[]>();
            if(Text.m_stringLength < 1)
            {
                    return val_1;
            }
            
            do
            {
                System.String[] val_3 = I2.Loc.LocalizationReader.ParseCSVline(Line:  Text, iStart: ref  0, Separator:  Separator);
                if(val_3 == null)
            {
                    return val_1;
            }
            
                val_1.Add(item:  val_3);
            }
            while(0 < Text.m_stringLength);
            
            return val_1;
        }
        private static string[] ParseCSVline(string Line, ref int iStart, char Separator)
        {
            int val_17;
            int val_18;
            string val_12 = Line;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            val_17 = iStart;
            int val_13 = val_17;
            if(val_17 >= Line.m_stringLength)
            {
                goto label_16;
            }
            
            label_15:
            char val_2 = Line.Chars[val_17];
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            if((val_2 & 65535) != '"')
            {
                goto label_4;
            }
            
            int val_15 = iStart;
            int val_4 = val_15 + 1;
            if(val_4 >= Line.m_stringLength)
            {
                goto label_14;
            }
            
            val_15 = Line.Chars[val_4] & 65535;
            if(val_15 != '"')
            {
                goto label_14;
            }
            
            val_18 = iStart;
            int val_6 = val_18 + 2;
            if(val_6 >= Line.m_stringLength)
            {
                goto label_8;
            }
            
            val_18 = iStart;
            if((Line.Chars[val_6] & 65535) != '"')
            {
                goto label_8;
            }
            
            val_18 = val_18 + 2;
            iStart = val_18;
            goto label_14;
            label_3:
            char val_9 = val_2 & 65535;
            if((val_9 == '
            ') || (val_9 == Separator))
            {
                goto label_11;
            }
            
            var val_11 = ((val_2 & 65535) == '"') ? 1 : 0;
            goto label_14;
            label_11:
            I2.Loc.LocalizationReader.AddCSVtoken(list: ref  val_1, Line: ref  val_12, iEnd:  iStart, iWordStart: ref  val_13);
            if(val_9 == '
            ')
            {
                goto label_13;
            }
            
            goto label_14;
            label_8:
            val_18 = val_18 + 1;
            iStart = val_18;
            label_4:
            label_14:
            val_17 = iStart + 1;
            iStart = val_17;
            if(val_17 < Line.m_stringLength)
            {
                goto label_15;
            }
            
            goto label_16;
            label_13:
            val_17 = iStart + 1;
            iStart = val_17;
            label_16:
            if(val_17 <= val_13)
            {
                    return (System.String[])val_1.ToArray();
            }
            
            I2.Loc.LocalizationReader.AddCSVtoken(list: ref  val_1, Line: ref  val_12, iEnd:  val_17, iWordStart: ref  val_13);
            return (System.String[])val_1.ToArray();
        }
        private static void AddCSVtoken(ref System.Collections.Generic.List<string> list, ref string Line, int iEnd, ref int iWordStart)
        {
            string val_10;
            iEnd = iEnd - iWordStart;
            iWordStart = iEnd + 1;
            val_10 = Line.Substring(startIndex:  iWordStart, length:  iEnd).Replace(oldValue:  "\"\"", newValue:  "\"");
            if((val_3.m_stringLength >= 2) && ((val_10.Chars[0] & 65535) == '"'))
            {
                    int val_10 = val_3.m_stringLength;
                val_10 = (val_10.Chars[val_10 - 1]) & 65535;
                if(val_10 == '"')
            {
                    val_10 = val_10.Substring(startIndex:  1, length:  val_3.m_stringLength - 2);
            }
            
            }
            
            list.Add(item:  val_10);
        }
        public static System.Collections.Generic.List<string[]> ReadI2CSV(string Text)
        {
            string[] val_1 = new string[1];
            val_1[0] = "[*]";
            string[] val_2 = new string[1];
            val_2[0] = "[ln]";
            System.Collections.Generic.List<System.String[]> val_3 = new System.Collections.Generic.List<System.String[]>();
            if(val_4.Length < 1)
            {
                    return val_3;
            }
            
            var val_7 = 0;
            do
            {
                val_3.Add(item:  Text.Split(separator:  val_2, options:  0)[val_7].Split(separator:  val_1, options:  0));
                val_7 = val_7 + 1;
            }
            while(val_7 < val_4.Length);
            
            return val_3;
        }
        public static void ValidateFullTerm(ref string Term)
        {
            string val_1 = Term.Replace(oldChar:  '\', newChar:  '/');
            Term = val_1;
            int val_2 = val_1.IndexOf(value:  '/');
            if((val_2 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                int val_3 = Term.LastIndexOf(value:  '/');
                if(val_3 == val_2)
            {
                    return;
            }
            
                string val_4 = Term.Remove(startIndex:  val_3, count:  1);
                Term = val_4;
            }
            while(val_4 != null);
            
            throw new NullReferenceException();
        }
        public static string EncodeString(string str)
        {
            if((System.String.IsNullOrEmpty(value:  str)) == false)
            {
                    return str.Replace(oldValue:  "\r\n", newValue:  "<\\n>").Replace(oldValue:  "\r", newValue:  "<\\n>").Replace(oldValue:  "\n", newValue:  "<\\n>");
            }
            
            return (string)System.String.alignConst;
        }
        public static string DecodeString(string str)
        {
            if((System.String.IsNullOrEmpty(value:  str)) == false)
            {
                    return str.Replace(oldValue:  "<\\n>", newValue:  "\r\n");
            }
            
            return (string)System.String.alignConst;
        }
        public LocalizationReader()
        {
        
        }
    
    }

}
