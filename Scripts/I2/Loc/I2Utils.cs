using UnityEngine;

namespace I2.Loc
{
    public static class I2Utils
    {
        // Fields
        public const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";
        public const string NumberChars = "0123456789";
        public const string ValidNameSymbols = ".-_$#@*()[]{}+:?!&\',^=<>~`";
        
        // Methods
        public static string ReverseText(string source)
        {
            char[] val_1 = new char[0];
            if(source.m_stringLength < 1)
            {
                    return 0.CreateString(val:  val_1);
            }
            
            var val_4 = 0;
            var val_2 = (long)source.m_stringLength - 1;
            do
            {
                val_4 = val_4 + 1;
                val_2 = val_2 - 1;
                val_1[val_2 << 1] = source.Chars[0];
            }
            while(val_4 < (long)source.m_stringLength);
            
            return 0.CreateString(val:  val_1);
        }
        public static string RemoveNonASCII(string text, bool allowCategory = False)
        {
            var val_9;
            char val_10;
            if((System.String.IsNullOrEmpty(value:  text)) != false)
            {
                    return (string)text;
            }
            
            char[] val_2 = new char[0];
            int val_9 = val_4.Length;
            if(val_9 < 1)
            {
                goto label_5;
            }
            
            val_9 = 0;
            var val_10 = 0;
            val_9 = val_9 & 4294967295;
            label_25:
            if((allowCategory != false) && (1152921505166187982 <= 58))
            {
                    if(0 != 8193)
            {
                goto label_14;
            }
            
            }
            
            if((System.Char.IsLetterOrDigit(c:  '�')) != true)
            {
                    if(((IndexOf(value:  '�')) & 2147483648) != 0)
            {
                    val_10 = 32;
            }
            
            }
            
            label_14:
            if((System.Char.IsWhiteSpace(c:  ' ')) == false)
            {
                goto label_22;
            }
            
            var val_8 = (val_9 < 1) ? 1 : 0;
            val_8 = 0 | val_8;
            if((val_8 & 1) == 0)
            {
                goto label_18;
            }
            
            goto label_19;
            label_18:
            val_10 = 32;
            label_22:
            val_9 = val_9 + 1;
            val_2[0] = val_10;
            label_19:
            val_10 = val_10 + 1;
            if(val_10 < (val_4.Length << ))
            {
                goto label_25;
            }
            
            return 0.CreateString(val:  val_2, startIndex:  0, length:  0);
            label_5:
            val_9 = 0;
            return 0.CreateString(val:  val_2, startIndex:  0, length:  0);
        }
        public static string GetValidTermName(string text, bool allowCategory = False)
        {
            if(text == null)
            {
                    return (string)text;
            }
            
            allowCategory = allowCategory;
            return I2.Loc.I2Utils.RemoveNonASCII(text:  I2.Loc.I2Utils.RemoveTags(text:  text), allowCategory:  allowCategory);
        }
        public static string SplitLine(string line, int maxCharacters)
        {
            var val_10;
            System.Func<System.Char, System.Boolean> val_12;
            if(maxCharacters < 1)
            {
                    return (string)line;
            }
            
            if(line.m_stringLength < maxCharacters)
            {
                    return (string)line;
            }
            
            System.Char[] val_1 = line.ToCharArray();
            if(val_1.Length < 1)
            {
                goto label_5;
            }
            
            var val_9 = 0;
            int val_2 = val_1.Length & 4294967295;
            goto label_24;
            label_21:
            mem2[0] = 0;
            goto label_23;
            label_24:
            val_2 = val_2 & 4294967295;
            if((1 & 1) == 0)
            {
                goto label_8;
            }
            
            if((((null == 10) ? 0 : (0 + 1)) < maxCharacters) || ((System.Char.IsWhiteSpace(c:  '�')) == false))
            {
                goto label_13;
            }
            
            mem2[0] = 10;
            goto label_23;
            label_8:
            if((System.Char.IsWhiteSpace(c:  '�')) == false)
            {
                goto label_19;
            }
            
            if(null != 10)
            {
                goto label_21;
            }
            
            if((0 & 1) != 0)
            {
                goto label_23;
            }
            
            mem2[0] = 0;
            goto label_23;
            label_19:
            label_13:
            label_23:
            val_9 = val_9 + 1;
            if(val_9 < (val_1.Length << ))
            {
                goto label_24;
            }
            
            label_5:
            val_10 = null;
            val_10 = null;
            val_12 = I2Utils.<>c.<>9__6_0;
            if(val_12 != null)
            {
                    return 0.CreateString(val:  System.Linq.Enumerable.ToArray<System.Char>(source:  System.Linq.Enumerable.Where<System.Char>(source:  val_1, predicate:  System.Func<System.Char, System.Boolean> val_6 = null)));
            }
            
            val_12 = val_6;
            val_6 = new System.Func<System.Char, System.Boolean>(object:  I2Utils.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean I2Utils.<>c::<SplitLine>b__6_0(char c));
            I2Utils.<>c.<>9__6_0 = val_12;
            return 0.CreateString(val:  System.Linq.Enumerable.ToArray<System.Char>(source:  System.Linq.Enumerable.Where<System.Char>(source:  val_1, predicate:  val_6)));
        }
        public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
        {
            int val_14;
            tagStart = 0;
            tagEnd = 0;
            goto label_1;
            label_15:
            iStart = iStart + 1;
            tagEnd = iStart;
            if(iStart >= W25)
            {
                    return false;
            }
            
            var val_14 = 0;
            label_6:
            char val_1 = line.Chars[iStart];
            char val_2 = val_1 & 65535;
            char val_3 = val_2 - 62;
            if(val_3 > ('?'))
            {
                goto label_3;
            }
            
            val_3 = 1 << val_3;
            if(val_3 != '')
            {
                goto label_5;
            }
            
            label_3:
            if(val_2 == ')')
            {
                goto label_5;
            }
            
            iStart = tagEnd + 1;
            val_14 = val_14 | (((val_1 & 65535) > 'ÿ') ? 1 : 0);
            tagEnd = iStart;
            if(iStart < W25)
            {
                goto label_6;
            }
            
            return false;
            label_5:
            if((val_14 & 1) == 0)
            {
                    return false;
            }
            
            int val_15 = tagEnd;
            tagStart = 0;
            tagEnd = 0;
            val_14 = val_15 + 1;
            label_1:
            tagStart = val_14;
            if(val_14 >= line.m_stringLength)
            {
                goto label_9;
            }
            
            label_14:
            val_15 = line.Chars[val_14] & 65535;
            if((((val_15 == '[') || ((line.Chars[tagStart] & 65535) == '(')) || ((line.Chars[tagStart] & 65535) == '{')) || ((line.Chars[tagStart] & 65535) == ('<')))
            {
                goto label_13;
            }
            
            int val_13 = tagStart + 1;
            tagStart = val_13;
            if(val_13 < line.m_stringLength)
            {
                goto label_14;
            }
            
            label_13:
            val_14 = tagStart;
            label_9:
            if(val_14 != line.m_stringLength)
            {
                goto label_15;
            }
            
            return false;
        }
        public static string RemoveTags(string text)
        {
            return System.Text.RegularExpressions.Regex.Replace(input:  text, pattern:  "\\{\\[(.*?)]}|\\[(.*?)]|\\<(.*?)>", replacement:  "");
        }
        public static bool RemoveResourcesPath(ref string sPath)
        {
            string val_14;
            int val_15;
            var val_16;
            int[] val_5 = new int[4];
            val_5[0] = sPath.IndexOf(value:  "\\Resources\\");
            val_5[0] = sPath.IndexOf(value:  "\\Resources/");
            val_5[1] = sPath.IndexOf(value:  "/Resources\\");
            val_5[1] = sPath.IndexOf(value:  "/Resources/");
            int val_6 = UnityEngine.Mathf.Max(values:  val_5);
            val_14 = sPath;
            if((val_6 & 2147483648) == 0)
            {
                    val_15 = val_6 + 11;
                val_16 = 1;
            }
            else
            {
                    int val_7 = val_14.LastIndexOfAny(anyOf:  I2.Loc.LanguageSourceData.CategorySeparators);
                val_14 = sPath;
                if(val_7 < 1)
            {
                goto label_25;
            }
            
                val_16 = 0;
                val_15 = val_7 + 1;
            }
            
            string val_8 = val_14.Substring(startIndex:  val_15);
            sPath = val_8;
            label_25:
            if((System.String.IsNullOrEmpty(value:  System.IO.Path.GetExtension(path:  val_8))) == true)
            {
                    return (bool)val_16;
            }
            
            sPath = sPath.Substring(startIndex:  0, length:  val_8.m_stringLength - val_9.m_stringLength);
            return (bool)val_16;
        }
        public static bool IsPlaying()
        {
            return UnityEngine.Application.isPlaying;
        }
        public static string GetPath(UnityEngine.Transform tr)
        {
            if(tr != 0)
            {
                    return tr.parent + "/"("/") + tr.name;
            }
            
            return tr.name;
        }
        public static UnityEngine.Transform FindObject(string objectPath)
        {
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            val_1.m_Handle = val_1.m_Handle & 4294967295;
            return I2.Loc.I2Utils.FindObject(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_1.m_Handle}, objectPath:  objectPath);
        }
        public static UnityEngine.Transform FindObject(UnityEngine.SceneManagement.Scene scene, string objectPath)
        {
            UnityEngine.Transform val_11;
            if((???) < 1)
            {
                goto label_2;
            }
            
            var val_11 = 0;
            label_9:
            UnityEngine.Transform val_1 = ???.transform;
            val_11 = val_1;
            if((System.String.op_Equality(a:  val_1.name, b:  objectPath)) == true)
            {
                    return (UnityEngine.Transform)val_11;
            }
            
            if((objectPath.StartsWith(value:  val_11.name + "/"("/"))) == true)
            {
                goto label_8;
            }
            
            val_11 = val_11 + 1;
            if(val_11 < (???))
            {
                goto label_9;
            }
            
            label_2:
            val_11 = 0;
            return (UnityEngine.Transform)val_11;
            label_8:
            string val_7 = val_11.name;
            val_11 = I2.Loc.I2Utils.FindObject(root:  val_11, objectPath:  objectPath.Substring(startIndex:  val_7.m_stringLength + 1));
            return (UnityEngine.Transform)val_11;
        }
        public static UnityEngine.Transform FindObject(UnityEngine.Transform root, string objectPath)
        {
            var val_12;
            var val_13;
            var val_14;
            val_12 = root;
            goto label_0;
            label_10:
            val_13 = 0;
            label_5:
            UnityEngine.Transform val_1 = val_12.GetChild(index:  0);
            val_14 = val_1;
            if((System.String.op_Equality(a:  val_1.name, b:  objectPath)) == true)
            {
                    return (UnityEngine.Transform)val_14;
            }
            
            if((objectPath.StartsWith(value:  val_14.name + "/"("/"))) == true)
            {
                goto label_4;
            }
            
            val_13 = val_13 + 1;
            if(val_13 < val_12.childCount)
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            string val_8 = val_14.name;
            string val_10 = objectPath.Substring(startIndex:  val_8.m_stringLength + 1);
            val_12 = val_14;
            label_0:
            if(val_12.childCount >= 1)
            {
                goto label_10;
            }
            
            label_6:
            val_14 = 0;
            return (UnityEngine.Transform)val_14;
        }
        public static H FindInParents<H>(UnityEngine.Transform tr)
        {
            UnityEngine.Object val_5 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  tr)) == false)
            {
                    return (object)val_5;
            }
            
            val_5 = tr;
            goto label_5;
            label_12:
            if((UnityEngine.Object.op_Implicit(exists:  tr)) == false)
            {
                    return (object)val_5;
            }
            
            val_5 = tr;
            UnityEngine.Transform val_3 = tr.parent;
            label_5:
            if((UnityEngine.Object.op_Implicit(exists:  val_5)) == false)
            {
                goto label_12;
            }
            
            return (object)val_5;
        }
        public static string GetCaptureMatch(System.Text.RegularExpressions.Match match)
        {
            var val_5;
            int val_5 = match.Count;
            label_5:
            val_5 = val_5 - 1;
            if(<0)
            {
                goto label_2;
            }
            
            if(match.Item[val_5].Success == false)
            {
                goto label_5;
            }
            
            System.Text.RegularExpressions.Group val_4 = match.Item[val_5];
            val_5 = public System.String System.Text.RegularExpressions.Capture::ToString();
            return match.ToString();
            label_2:
            val_5 = public System.String System.Text.RegularExpressions.Capture::ToString();
            return match.ToString();
        }
        public static void SendWebRequest(UnityEngine.Networking.UnityWebRequest www)
        {
            if(www != null)
            {
                    UnityEngine.Networking.UnityWebRequestAsyncOperation val_1 = www.SendWebRequest();
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
