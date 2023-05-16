using UnityEngine;

namespace Royal.Infrastructure.Utils.Text
{
    public class EmojiReplacement
    {
        // Fields
        public System.Collections.Generic.Dictionary<string, string> replacementDictionary;
        public System.Collections.Generic.Dictionary<string, string> originalDictionary;
        
        // Methods
        public EmojiReplacement()
        {
            string val_8;
            this.replacementDictionary = new System.Collections.Generic.Dictionary<System.String, System.String>();
            this.originalDictionary = new System.Collections.Generic.Dictionary<System.String, System.String>();
            val_8 = UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  "EmojiReplacements").text;
            System.IO.StringReader val_5 = new System.IO.StringReader(s:  val_8);
            if(val_5 == null)
            {
                    return;
            }
            
            do
            {
                char[] val_6 = new char[1];
                val_6[0] = ';';
                System.String[] val_7 = val_5.Split(separator:  val_6);
                val_8 = val_5;
                this.replacementDictionary.Add(key:  val_7[0], value:  val_7[1]);
                this.originalDictionary.Add(key:  val_7[1], value:  val_7[0]);
            }
            while(val_8 != null);
        
        }
        public string GetCustomEmojiReplacement(string originalText)
        {
            if((this.replacementDictionary.TryGetValue(key:  originalText, value: out  0)) == true)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        public string GetOriginalTextBack(string customEmojiText)
        {
            if((this.originalDictionary.TryGetValue(key:  customEmojiText, value: out  0)) == true)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
    
    }

}
