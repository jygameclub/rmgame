using UnityEngine;

namespace I2.Loc
{
    internal class RTLFixerTool
    {
        // Fields
        internal static bool showTashkeel;
        internal static bool useHinduNumbers;
        
        // Methods
        internal static string RemoveTashkeel(string str, out System.Collections.Generic.List<I2.Loc.TashkeelLocation> tashkeelLocation)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            string val_17;
            tashkeelLocation = new System.Collections.Generic.List<I2.Loc.TashkeelLocation>();
            int val_7 = val_2.Length;
            val_7 = str.ToCharArray();
            if(val_7 < 1)
            {
                goto label_3;
            }
            
            val_8 = 1152921528808421520;
            val_9 = 0;
            var val_19 = 0;
            val_7 = val_7 & 4294967295;
            val_10 = 36604580;
            label_60:
            if(1152921505166186405 > 8)
            {
                goto label_58;
            }
            
            var val_8 = mem[4611686020701350200];
            val_8 = val_8 + val_10;
            goto (mem[4611686020701350200] + val_10);
            label_58:
            val_19 = val_19 + 1;
            if(val_19 < (val_2.Length << ))
            {
                goto label_60;
            }
            
            label_3:
            int val_20 = val_5.Length;
            val_17 = "";
            if(val_20 < 1)
            {
                    return (string)val_17 + null;
            }
            
            var val_21 = 0;
            val_20 = val_20 & 4294967295;
            do
            {
                val_21 = val_21 + 1;
            }
            while(val_21 < (val_5.Length << ));
            
            return (string)val_17 + null;
        }
        internal static char[] ReturnTashkeel(char[] letters, System.Collections.Generic.List<I2.Loc.TashkeelLocation> tashkeelLocation)
        {
            var val_4;
            var val_5;
            int val_1 = true + letters.Length;
            char[] val_2 = new char[0];
            int val_7 = letters.Length;
            if(val_7 < 1)
            {
                    return (System.Char[])val_2;
            }
            
            var val_11 = 0;
            var val_9 = 0;
            val_7 = val_7 & 4294967295;
            var val_10 = 0;
            label_14:
            val_2[0] = letters[0];
            List.Enumerator<T> val_3 = tashkeelLocation.GetEnumerator();
            goto label_7;
            label_11:
            val_2[0] = val_4 + 16;
            label_7:
            val_9 = val_9 + 1;
            label_10:
            if(((-1567838976) & 1) == 0)
            {
                goto label_8;
            }
            
            if(val_4 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((val_4 + 20) != val_9)
            {
                goto label_10;
            }
            
            if(val_9 < val_2.Length)
            {
                goto label_11;
            }
            
            throw new IndexOutOfRangeException();
            label_8:
            val_10 = val_10 + 1;
            val_5.Dispose();
            if(val_10 != 1)
            {
                    val_10 = val_10 + (0 ^ (val_10 >> 31));
            }
            
            val_11 = val_11 + 1;
            if(val_11 < (letters.Length << ))
            {
                goto label_14;
            }
            
            return (System.Char[])val_2;
        }
        internal static string FixLine(string str)
        {
            int val_44;
            System.Char[] val_45;
            var val_46;
            var val_47;
            char val_49;
            var val_50;
            var val_53;
            var val_54;
            int val_55;
            char val_56;
            var val_57;
            var val_58;
            int val_59;
            int val_60;
            System.Collections.Generic.List<I2.Loc.TashkeelLocation> val_1 = 0;
            string val_2 = I2.Loc.RTLFixerTool.RemoveTashkeel(str:  str, tashkeelLocation: out  val_1);
            System.Char[] val_3 = val_2.ToCharArray();
            val_44 = val_3.Length;
            val_45 = val_2.ToCharArray();
            if(val_44 >= 1)
            {
                    var val_48 = 0;
                do
            {
                val_44 = val_3.Length;
                mem2[0] = I2.Loc.ArabicTable.ArabicMapper.Convert(toBeConverted:  559341040);
                val_48 = val_48 + 1;
            }
            while(val_48 < (val_44 << ));
            
            }
            
            if(val_44 < 1)
            {
                goto label_10;
            }
            
            val_46 = 36604540;
            label_82:
            val_47 = 0;
            if((0 >= (val_44 - 1)) || (val_3[0] != 'ﻝ'))
            {
                goto label_15;
            }
            
            char val_50 = val_3[2];
            val_47 = 0;
            char val_8 = val_50 + 383;
            val_50 = val_8 << 15;
            val_8 = val_50 & 65535;
            if(val_8 > '')
            {
                goto label_15;
            }
            
            val_50 = val_50 & 65535;
            var val_51 = 36604512 + ((((val_3[0x2][0] + 383) << 15) & 65535)) << 2;
            val_51 = val_51 + 36604512;
            goto (36604512 + ((((val_3[0x2][0] + 383) << 15) & 65535)) << 2 + 36604512);
            label_15:
            if((I2.Loc.RTLFixerTool.IsIgnoredCharacter(ch:  val_3[0x0] + 32)) == true)
            {
                goto label_41;
            }
            
            if((I2.Loc.RTLFixerTool.IsMiddleLetter(letters:  val_3, index:  0)) == false)
            {
                goto label_27;
            }
            
            val_49 = (val_3[0x0] + 32) + 3;
            goto label_38;
            label_27:
            if((I2.Loc.RTLFixerTool.IsFinishingLetter(letters:  val_3, index:  0)) == false)
            {
                goto label_34;
            }
            
            val_49 = (val_3[0x0] + 32) + 1;
            goto label_38;
            label_34:
            if((I2.Loc.RTLFixerTool.IsLeadingLetter(letters:  val_3, index:  0)) == false)
            {
                goto label_41;
            }
            
            val_49 = (val_3[0x0] + 32) + 2;
            label_38:
            val_45[0] = val_49;
            label_41:
            string val_14 = "" + System.Convert.ToString(value:  val_3[0x0] + 32, toBase:  16)(System.Convert.ToString(value:  val_3[0x0] + 32, toBase:  16)) + " ";
            val_50 = null;
            val_50 = null;
            var val_15 =  + 0;
            if(I2.Loc.RTLFixerTool.useHinduNumbers == false)
            {
                goto label_52;
            }
            
            char val_52 = val_3[((long)(int)((val_47 + 0))) << 1];
            val_52 = val_52 - 48;
            if(val_52 > '	')
            {
                goto label_52;
            }
            
            var val_53 = val_46 + ((val_3[((long)(int)((val_47 + 0))) << 1][0] - 48)) << 2;
            val_53 = val_53 + val_46;
            goto (val_46 + ((val_3[((long)(int)((val_47 + 0))) << 1][0] - 48)) << 2 + val_46);
            label_52:
            val_15 = val_15 + 1;
            if(val_15 < val_3.Length)
            {
                goto label_82;
            }
            
            label_10:
            val_53 = null;
            val_53 = null;
            if(I2.Loc.RTLFixerTool.showTashkeel != false)
            {
                    val_45 = I2.Loc.RTLFixerTool.ReturnTashkeel(letters:  val_45, tashkeelLocation:  val_1);
            }
            
            System.Collections.Generic.List<System.Char> val_17 = new System.Collections.Generic.List<System.Char>();
            System.Collections.Generic.List<System.Char> val_18 = null;
            val_54 = val_18;
            val_18 = new System.Collections.Generic.List<System.Char>();
            val_55 = val_16.Length;
            int val_19 = val_55 - 1;
            if(val_15 < 0)
            {
                goto label_205;
            }
            
            label_206:
            var val_22 = (long)val_19 - 1;
            if(((val_55 & 4294967295) < (val_19 << )) || ((System.Char.IsPunctuation(c:  val_45[((long)(int)((val_16.Length - 1))) << 1])) == false))
            {
                goto label_103;
            }
            
            var val_55 = -4294967296;
            val_55 = val_55 + ((val_16.Length) << 32);
            if((long)val_19 >= (val_55 >> 32))
            {
                goto label_103;
            }
            
            if((System.Char.IsPunctuation(c:  val_45[(val_55 - 2) << 1])) == true)
            {
                goto label_99;
            }
            
            if((System.Char.IsPunctuation(c:  val_45[val_55 << 1])) == false)
            {
                goto label_103;
            }
            
            label_99:
            val_56 = mem[val_16[((long)(int)((val_16.Length - 1))) << 1] + 32];
            val_56 = val_16[((long)(int)((val_16.Length - 1))) << 1] + 32;
            if(val_56 <= 61)
            {
                goto label_105;
            }
            
            if(val_56 > 92)
            {
                goto label_106;
            }
            
            if(val_56 == 62)
            {
                goto label_107;
            }
            
            if(val_56 == 91)
            {
                goto label_169;
            }
            
            goto label_177;
            label_103:
            int val_26 = val_16.Length & 4294967295;
            if((((long)val_19 >= (((-4294967296) + (((val_16.Length & 4294967295)) << 32)) >> 32)) || ((long)val_19 < 1)) || ((val_16[((long)(int)((val_16.Length - 1))) << 1] + 32) != 32))
            {
                goto label_137;
            }
            
            if((System.Char.IsLower(c:  val_45[(val_55 - 2) << 1])) != true)
            {
                    if((System.Char.IsUpper(c:  val_16[((val_16.Length - 2)) << 1] + 32)) != true)
            {
                    if((System.Char.IsNumber(c:  val_16[((val_16.Length - 2)) << 1] + 32)) == false)
            {
                goto label_137;
            }
            
            }
            
            }
            
            if((System.Char.IsLower(c:  val_45[val_55 << 1])) != true)
            {
                    if((System.Char.IsUpper(c:  val_16[(val_16.Length) << 1] + 32)) != true)
            {
                    if((System.Char.IsNumber(c:  val_16[(val_16.Length) << 1] + 32)) == false)
            {
                goto label_137;
            }
            
            }
            
            }
            
            val_56 = mem[val_16[((long)(int)((val_16.Length - 1))) << 1] + 32];
            val_56 = val_16[((long)(int)((val_16.Length - 1))) << 1] + 32;
            label_185:
            val_57 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
            goto label_140;
            label_137:
            if((((System.Char.IsNumber(c:  val_16[((long)(int)((val_16.Length - 1))) << 1] + 32)) != true) && ((System.Char.IsLower(c:  val_16[((long)(int)((val_16.Length - 1))) << 1] + 32)) != true)) && ((System.Char.IsUpper(c:  val_16[((long)(int)((val_16.Length - 1))) << 1] + 32)) != true))
            {
                    if((System.Char.IsSymbol(c:  val_16[((long)(int)((val_16.Length - 1))) << 1] + 32)) != true)
            {
                    if((System.Char.IsPunctuation(c:  val_16[((long)(int)((val_16.Length - 1))) << 1] + 32)) == false)
            {
                goto label_160;
            }
            
            }
            
            }
            
            if((val_16[((long)(int)((val_16.Length - 1))) << 1] + 32) > 61)
            {
                goto label_162;
            }
            
            if((((val_16[((long)(int)((val_16.Length - 1))) << 1] + 32) == 40) || ((val_16[((long)(int)((val_16.Length - 1))) << 1] + 32) == 41)) || ((val_16[((long)(int)((val_16.Length - 1))) << 1] + 32) != 60))
            {
                goto label_185;
            }
            
            goto label_185;
            label_162:
            if((val_16[((long)(int)((val_16.Length - 1))) << 1] + 32) == 62)
            {
                goto label_185;
            }
            
            if((val_16[((long)(int)((val_16.Length - 1))) << 1] + 32) == 91)
            {
                goto label_169;
            }
            
            if((val_16[((long)(int)((val_16.Length - 1))) << 1] + 32) == 93)
            {
                goto label_170;
            }
            
            goto label_185;
            label_169:
            val_58 = 1152921511048916880;
            val_56 = 93;
            goto label_194;
            label_105:
            if(val_56 == 40)
            {
                goto label_175;
            }
            
            if(val_56 == 41)
            {
                goto label_176;
            }
            
            if(val_56 != 60)
            {
                goto label_177;
            }
            
            val_58 = 1152921511048916880;
            val_56 = 62;
            goto label_194;
            label_106:
            if(val_56 != 93)
            {
                goto label_186;
            }
            
            label_170:
            val_58 = 1152921511048916880;
            val_56 = 91;
            goto label_194;
            label_107:
            val_58 = 1152921511048916880;
            val_56 = 60;
            goto label_194;
            label_175:
            val_58 = 1152921511048916880;
            val_56 = 41;
            goto label_194;
            label_176:
            val_58 = 1152921511048916880;
            val_56 = 40;
            goto label_194;
            label_160:
            val_59 = val_16.Length;
            var val_40 = (val_16[((long)(int)((val_16.Length - 1))) << 1] + 32) >> 11;
            if(val_40 == 27)
            {
                goto label_185;
            }
            
            if(val_40 >= 1)
            {
                    var val_60 = 0;
                do
            {
                if(val_40 < 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_40 = val_40 + ((val_40 + 0) << 1);
                val_17.Add(item:  ((val_16[((long)(int)((val_16.Length - 1))) << 1] + 32 >> 11) + (((val_16[((long)(int)((val_16.Length - 1))) << 1] + 32 >> 11) + 0)) << 1) + 32);
                val_60 = val_60 + 1;
                val_55 = 0 - 1;
            }
            while(val_60 < val_40);
            
                val_18.Clear();
                val_59 = val_16.Length;
            }
            
            val_56 = mem[val_16[((long)(int)((val_16.Length - 1))) << 1] + 32];
            val_56 = val_16[((long)(int)((val_16.Length - 1))) << 1] + 32;
            label_186:
            if(val_56 == 65535)
            {
                goto label_203;
            }
            
            label_177:
            val_58 = 1152921511048916880;
            label_194:
            label_140:
            val_17.Add(item:  val_56);
            label_203:
            if((val_22 & 2147483648) == 0)
            {
                    if(val_22 < val_16.Length)
            {
                goto label_206;
            }
            
            }
            
            label_205:
            if(val_19 >= 1)
            {
                    val_55 = 1152921511048916880;
                var val_61 = 0;
                var val_62 = 0;
                do
            {
                if(val_19 < 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_19 = val_19 + ((val_19 + val_62) << 1);
                val_17.Add(item:  ((val_16.Length - 1) + (((val_16.Length - 1) + 0)) << 1) + 32);
                val_61 = val_61 + 1;
                val_62 = val_62 - 1;
            }
            while(val_61 < val_19);
            
                val_18.Clear();
            }
            
            char[] val_43 = new char[-2147281744];
            if(val_43.Length < 1)
            {
                    return (string)0.CreateString(val:  val_43);
            }
            
            val_60 = val_43.Length & 4294967295;
            do
            {
                if((16 - 16) >= val_3.Length)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_60 = val_43.Length;
            }
            
                val_43[0] = val_3.Length + 32;
                val_54 = 16 + 1;
            }
            while((16 - 15) < (val_60 << ));
            
            return (string)0.CreateString(val:  val_43);
        }
        internal static bool IsIgnoredCharacter(char ch)
        {
            var val_20;
            var val_20 = 64341;
            val_20 = val_20 + ch;
            if(val_20 > ('<'))
            {
                goto label_4;
            }
            
            val_20 = 1 << val_20;
            if((val_20 & '') != 0)
            {
                goto label_4;
            }
            
            val_20 = 1;
            goto label_5;
            label_4:
            var val_7 = ((ch & 65535) == 'ﮎ') ? 1 : 0;
            label_5:
            char val_8 = ch + 400;
            bool val_9 = (System.Char.IsPunctuation(c:  ch)) | (System.Char.IsNumber(c:  ch));
            val_8 = val_8 & 65535;
            val_9 = val_9 | (System.Char.IsLower(c:  ch));
            bool val_10 = val_9 | (System.Char.IsUpper(c:  ch));
            val_7 = val_7 | ((val_8 < '') ? 1 : 0);
            var val_13 = (val_7 == 0) ? 1 : 0;
            val_10 = val_10 | (System.Char.IsSymbol(c:  ch));
            if(val_10 == true)
            {
                    return true;
            }
            
            val_13 = val_13 & (((ch & 65535) != 'ﯼ') ? 1 : 0);
            if((val_13 & 1) != 0)
            {
                    return true;
            }
            
            char val_15 = ch & 65535;
            if(val_15 == ('>'))
            {
                    return true;
            }
            
            if(val_15 == 'a')
            {
                    return true;
            }
            
            char val_16 = ch & 65535;
            var val_19 = ((val_16 == ('<')) ? 1 : 0) | ((val_16 == '؛') ? 1 : 0);
            return true;
        }
        internal static bool IsLeadingLetter(char[] letters, int index)
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            if(index == 0)
            {
                goto label_1;
            }
            
            char val_15 = letters[(index - 1) << 1];
            char val_2 = val_15 - 32;
            if(val_2 > ('!'))
            {
                goto label_4;
            }
            
            val_2 = 1 << val_2;
            if(val_2 != 'Ё')
            {
                goto label_8;
            }
            
            label_4:
            if((System.Char.IsPunctuation(c:  val_15)) == true)
            {
                goto label_8;
            }
            
            val_15 = 1;
            if((letters[((index - 1)) << 1] + 32) <= 65152)
            {
                goto label_10;
            }
            
            var val_16 = 65152;
            val_16 = (letters[((index - 1)) << 1] + 32) + val_16;
            if(val_16 > 46)
            {
                goto label_11;
            }
            
            val_16 = 1 << val_16;
            if(val_16 != 4165)
            {
                goto label_48;
            }
            
            label_11:
            val_16 = 65261;
            goto label_13;
            label_1:
            label_8:
            val_15 = 1;
            label_48:
            char val_17 = letters[index << 1];
            if(val_17 <= 'ﺀ')
            {
                goto label_16;
            }
            
            var val_18 = 65152;
            val_18 = val_17 + val_18;
            if(val_18 > '.')
            {
                goto label_18;
            }
            
            val_18 = 1 << val_18;
            if((val_18 & 'ၕ') != 0)
            {
                goto label_18;
            }
            
            label_44:
            if((letters.Length - 1) <= index)
            {
                    return (bool)(0 & val_15) & 0;
            }
            
            val_14 = index + 1;
            char val_19 = letters[val_14 << 1];
            if(val_19 == ' ')
            {
                    return (bool)(0 & val_15) & 0;
            }
            
            if((System.Char.IsPunctuation(c:  val_19)) == true)
            {
                    return (bool)(0 & val_15) & 0;
            }
            
            if((System.Char.IsNumber(c:  letters[((index + 1)) << 1] + 32)) == true)
            {
                    return (bool)(0 & val_15) & 0;
            }
            
            if((System.Char.IsSymbol(c:  letters[((index + 1)) << 1] + 32)) == true)
            {
                    return (bool)(0 & val_15) & 0;
            }
            
            if((System.Char.IsLower(c:  letters[((index + 1)) << 1] + 32)) != true)
            {
                    if((System.Char.IsUpper(c:  letters[((index + 1)) << 1] + 32)) == false)
            {
                goto label_40;
            }
            
            }
            
            return (bool)(0 & val_15) & 0;
            label_16:
            if(val_17 == ' ')
            {
                goto label_44;
            }
            
            val_17 = 64394;
            goto label_42;
            label_18:
            val_17 = 65261;
            label_42:
            if(val_17 == 'ﻭ')
            {
                goto label_44;
            }
            
            var val_12 = (val_17 != 'ﺀ') ? 1 : 0;
            goto label_44;
            label_10:
            if(((letters[((index - 1)) << 1] + 32) == 60) || ((letters[((index - 1)) << 1] + 32) == 62))
            {
                goto label_48;
            }
            
            val_16 = 64394;
            label_13:
            if((letters[((index - 1)) << 1] + 32) == 64394)
            {
                goto label_48;
            }
            
            var val_13 = ((letters[((index - 1)) << 1] + 32) == 65157) ? 1 : 0;
            goto label_48;
            label_40:
            var val_14 = ((letters[((index + 1)) << 1] + 32) != 384) ? 1 : 0;
            return (bool)(0 & val_15) & 0;
        }
        internal static bool IsFinishingLetter(char[] letters, int index)
        {
            char val_7;
            var val_8;
            var val_9;
            if(index == 0)
            {
                goto label_1;
            }
            
            val_7 = letters[(index - 1) << 1];
            val_8 = 0;
            if(val_7 <= 'ﹿ')
            {
                goto label_4;
            }
            
            var val_7 = 65151;
            val_7 = val_7 + val_7;
            if(val_7 > ('/'))
            {
                goto label_5;
            }
            
            val_7 = 1 << val_7;
            if(val_7 != '₫')
            {
                goto label_17;
            }
            
            label_5:
            val_9 = 65261;
            goto label_7;
            label_1:
            label_16:
            val_8 = 0;
            label_17:
            char val_8 = letters[index << 1];
            var val_3 = (val_8 != 'ﺀ') ? 1 : 0;
            val_3 = ((val_8 != ' ') ? 1 : 0) & val_3;
            return (bool)val_8 & val_3;
            label_4:
            if(val_7 == ' ')
            {
                goto label_17;
            }
            
            val_9 = 64394;
            label_7:
            if(val_7 == 'ﮊ')
            {
                goto label_17;
            }
            
            if(((System.Char.IsPunctuation(c:  val_7)) == true) || ((letters[((index - 1)) << 1] + 32) == 62))
            {
                goto label_16;
            }
            
            var val_6 = ((letters[((index - 1)) << 1] + 32) != 60) ? 1 : 0;
            goto label_17;
        }
        internal static bool IsMiddleLetter(char[] letters, int index)
        {
            char val_13;
            char val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_14 = letters;
            if(index == 0)
            {
                goto label_1;
            }
            
            if(letters.Length <= index)
            {
                    throw new IndexOutOfRangeException();
            }
            
            char val_13 = val_14[index << 1];
            var val_14 = 65152;
            val_15 = 0;
            val_14 = val_13 + val_14;
            if(val_14 > '.')
            {
                goto label_5;
            }
            
            val_14 = 1 << val_14;
            if((val_14 & 'ၕ') != 0)
            {
                goto label_5;
            }
            
            label_38:
            int val_1 = index - 1;
            if(val_1 >= letters.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_13 = val_14[val_1 << 1];
            var val_15 = 65151;
            val_17 = 0;
            val_15 = val_13 + val_15;
            if(val_15 > ('/'))
            {
                goto label_7;
            }
            
            val_15 = 1 << val_15;
            if(val_15 != '₫')
            {
                goto label_43;
            }
            
            label_7:
            if((val_13 == 'ﮊ') || (val_13 == 'ﻭ'))
            {
                goto label_43;
            }
            
            if((System.Char.IsPunctuation(c:  val_13)) == true)
            {
                goto label_13;
            }
            
            if(val_1 >= letters.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            if((letters[((index - 1)) << 1] + 32) > 62)
            {
                goto label_16;
            }
            
            var val_16 = 1;
            val_16 = val_16 << (letters[((index - 1)) << 1] + 32);
            if((val_16 & 0) != 0)
            {
                goto label_16;
            }
            
            label_13:
            val_17 = 0;
            goto label_43;
            label_1:
            val_17 = 0;
            val_15 = 0;
            label_43:
            if((letters.Length - 1) <= index)
            {
                goto label_26;
            }
            
            val_16 = index + 1;
            if(val_16 >= letters.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_13 = val_14[val_16 << 1];
            val_18 = 0;
            if(((val_13 == '') || (val_13 == ' ')) || (val_13 == 'ﺀ'))
            {
                goto label_42;
            }
            
            if((System.Char.IsNumber(c:  val_13)) == true)
            {
                goto label_26;
            }
            
            if(val_16 >= letters.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_13 = mem[letters[((index + 1)) << 1] + 32];
            val_13 = letters[((index + 1)) << 1] + 32;
            if((System.Char.IsSymbol(c:  val_13)) == false)
            {
                goto label_30;
            }
            
            label_26:
            val_18 = 0;
            label_42:
            if(((val_17 & val_15) & val_18) != 0)
            {
                goto label_31;
            }
            
            val_14 = val_14[(index + 1) << 1];
            val_19 = (System.Char.IsPunctuation(c:  val_14)) ^ 1;
            return (bool)val_19 & 1;
            label_5:
            if((val_13 == 'ﮊ') || (val_13 == 'ﻭ'))
            {
                goto label_38;
            }
            
            var val_9 = (val_13 != 'ﺀ') ? 1 : 0;
            goto label_38;
            label_30:
            if(val_16 >= letters.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            var val_17 = ~(System.Char.IsPunctuation(c:  letters[((index + 1)) << 1] + 32));
            val_17 = val_17 & 1;
            goto label_42;
            label_16:
            var val_11 = ((letters[((index - 1)) << 1] + 32) != 42) ? 1 : 0;
            goto label_43;
            label_31:
            val_19 = 0;
            return (bool)val_19 & 1;
        }
        public RTLFixerTool()
        {
        
        }
        private static RTLFixerTool()
        {
            I2.Loc.RTLFixerTool.showTashkeel = true;
            I2.Loc.RTLFixerTool.useHinduNumbers = false;
        }
    
    }

}
