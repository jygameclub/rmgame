using UnityEngine;

namespace Royal.Infrastructure.Utils.Text
{
    public static class EmojiHelper
    {
        // Fields
        public static Royal.Infrastructure.Utils.Text.EmojiReplacement emojiReplacement;
        private static uint unassignedStartValue;
        
        // Methods
        public static uint CalculateEmojiUnicodeValue(string[] unicodeStrings)
        {
            return Royal.Infrastructure.Utils.Text.EmojiHelper.CalculateUnicodeValueWithOffset(value0:  System.UInt32.Parse(s:  unicodeStrings[0], style:  3), value1:  System.UInt32.Parse(s:  unicodeStrings[1], style:  3));
        }
        public static uint CalculateUnicodeValueWithOffset(uint value0, uint value1)
        {
            var val_3;
            uint val_4 = value1;
            uint val_3 = value0;
            val_3 = val_3 & 4095;
            val_4 = val_4 & 4095;
            val_3 = null;
            val_3 = null;
            return (uint)(val_4 + (val_3 * 200)) + Royal.Infrastructure.Utils.Text.EmojiHelper.unassignedStartValue;
        }
        public static uint GetUnicodeValueForString(string str)
        {
            var val_5;
            var val_6;
            if((System.String.op_Equality(a:  str, b:  "1f3f4-e0067-e0062-e0065-e006e-e0067-e007f")) != false)
            {
                    val_5 = 786432;
            }
            else
            {
                    val_5 = 786432;
                val_5 = 12;
                if((System.String.op_Equality(a:  str, b:  "1f3f4-e0067-e0062-e0073-e0063-e0074-e007f")) == false)
            {
                    return (uint)(((System.String.op_Equality(a:  str, b:  "1f3f4-e0067-e0062-e0077-e006c-e0073-e007f")) & true) != 0) ? 0 : (786433 + 1);
            }
            
            }
            
            val_6 = 786433;
            return (uint)(((System.String.op_Equality(a:  str, b:  "1f3f4-e0067-e0062-e0077-e006c-e0073-e007f")) & true) != 0) ? 0 : (786433 + 1);
        }
        public static string RemoveCustomEmojis(string str)
        {
            UnityEngine.Debug.Log(message:  val_1.m_stringLength);
            return (string)Royal.Infrastructure.Utils.Text.EmojiHelper.TryReplaceEmojiBack(str:  str);
        }
        private static string TryReplaceEmojiBack(string str)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_6 = str;
            val_7 = 0;
            do
            {
                if(val_7 >= str.m_stringLength)
            {
                    return (string)val_6;
            }
            
                if((val_7 + 2) > str.m_stringLength)
            {
                    return (string)val_6;
            }
            
                val_8 = null;
                val_8 = null;
                string val_3 = Royal.Infrastructure.Utils.Text.EmojiHelper.emojiReplacement.GetOriginalTextBack(customEmojiText:  val_6.Substring(startIndex:  0, length:  2));
                if((System.String.IsNullOrEmpty(value:  val_3)) != true)
            {
                    int val_7 = val_3.m_stringLength;
                val_6 = val_6.Remove(startIndex:  0, count:  2).Insert(startIndex:  0, value:  val_3);
                val_7 = val_7 + val_7;
                val_9 = val_7 - 1;
            }
            
                val_10 = val_9 + 1;
            }
            while(val_6 != null);
            
            throw new NullReferenceException();
        }
        public static string ReplaceWithCustomEmojis(string str)
        {
            System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
            val_1.Start();
            val_1.Restart();
            val_1.Restart();
            return Royal.Infrastructure.Utils.Text.EmojiHelper.TryReplaceWithEmoji(str:  Royal.Infrastructure.Utils.Text.EmojiHelper.TryReplaceWithEmoji(str:  Royal.Infrastructure.Utils.Text.EmojiHelper.TryReplaceWithEmoji(str:  str, charCount:  14, forceSurrogate:  true), charCount:  4, forceSurrogate:  true), charCount:  3, forceSurrogate:  false);
        }
        private static string TryReplaceWithEmoji(string str, int charCount, bool forceSurrogate)
        {
            var val_9;
            var val_10;
            char val_11;
            var val_12;
            var val_13;
            var val_14;
            val_9 = str;
            val_10 = 0;
            label_14:
            if(val_10 >= str.m_stringLength)
            {
                    return (string)val_9;
            }
            
            if((val_10 + charCount) > str.m_stringLength)
            {
                    return (string)val_9;
            }
            
            if(forceSurrogate == false)
            {
                goto label_4;
            }
            
            val_11 = val_9.Chars[0];
            if((System.Char.IsSurrogate(c:  val_11)) == false)
            {
                goto label_11;
            }
            
            label_4:
            val_12 = null;
            val_12 = null;
            string val_5 = Royal.Infrastructure.Utils.Text.EmojiHelper.emojiReplacement.GetCustomEmojiReplacement(originalText:  val_9.Substring(startIndex:  0, length:  charCount));
            val_11 = val_5;
            if((System.String.IsNullOrEmpty(value:  val_5)) != true)
            {
                    int val_9 = val_5.m_stringLength;
                val_9 = val_9.Remove(startIndex:  0, count:  charCount).Insert(startIndex:  0, value:  val_11);
                val_9 = val_10 + val_9;
                val_13 = val_9 - 1;
            }
            
            label_11:
            val_14 = val_13 + 1;
            if(val_9 != null)
            {
                goto label_14;
            }
            
            throw new NullReferenceException();
        }
        private static EmojiHelper()
        {
            Royal.Infrastructure.Utils.Text.EmojiHelper.emojiReplacement = new Royal.Infrastructure.Utils.Text.EmojiReplacement();
            Royal.Infrastructure.Utils.Text.EmojiHelper.unassignedStartValue = 262144;
        }
    
    }

}
